﻿using System.Configuration;
using System.Web.Hosting;

namespace Frapid.Configuration
{
    public static class ConfigurationManager
    {
        /// <summary>
        ///     Gets the configuration value of the requested key.
        /// </summary>
        /// <param name="configFileName">The name of the configuration file.</param>
        /// <param name="key">The configuration key to find.</param>
        /// <returns>Returns the configuration value of the requested key.</returns>
        public static string GetConfigurationValue(string configFileName, string key)
        {
            if (configFileName == null)
            {
                return string.Empty;
            }

            string fileName = System.Configuration.ConfigurationManager.AppSettings[configFileName];

            string path = HostingEnvironment.MapPath(fileName);
            return ReadConfigurationValue(path, key);
        }

        /// <summary>
        ///     Opens a configuration files and gets the configuration value of the requested key.
        /// </summary>
        /// <param name="path">The physical path to the configuration file.</param>
        /// <param name="key">The configuration key to find.</param>
        /// <returns>Returns the configuration value of the requested key.</returns>
        public static string ReadConfigurationValue(string path, string key)
        {
            var configFileMap = new ExeConfigurationFileMap {ExeConfigFilename = path};

            var config = System.Configuration.ConfigurationManager
                .OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            var section = config.GetSection("appSettings") as AppSettingsSection;

            return section?.Settings[key] != null ? section.Settings[key].Value : string.Empty;
        }
    }
}