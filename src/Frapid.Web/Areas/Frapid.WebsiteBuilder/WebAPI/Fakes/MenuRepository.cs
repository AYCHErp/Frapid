// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Frapid.WebsiteBuilder.DataAccess;
using Frapid.DataAccess;
using Frapid.DataAccess.Models;
using CustomField = Frapid.DataAccess.Models.CustomField;

namespace Frapid.WebsiteBuilder.Api.Fakes
{
    public class MenuRepository : IMenuRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> GetAll()
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public Frapid.WebsiteBuilder.Entities.Menu Get(int menuId)
        {
            return new Frapid.WebsiteBuilder.Entities.Menu();
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> Get(int[] menuIds)
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public Frapid.WebsiteBuilder.Entities.Menu GetFirst()
        {
            return new Frapid.WebsiteBuilder.Entities.Menu();
        }

        public Frapid.WebsiteBuilder.Entities.Menu GetPrevious(int menuId)
        {
            return new Frapid.WebsiteBuilder.Entities.Menu();
        }

        public Frapid.WebsiteBuilder.Entities.Menu GetNext(int menuId)
        {
            return new Frapid.WebsiteBuilder.Entities.Menu();
        }

        public Frapid.WebsiteBuilder.Entities.Menu GetLast()
        {
            return new Frapid.WebsiteBuilder.Entities.Menu();
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> GetPaginatedResult()
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public long CountWhere(List<Frapid.DataAccess.Models.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> GetWhere(long pageNumber, List<Frapid.DataAccess.Models.Filter> filters)
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<Frapid.DataAccess.Models.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new Frapid.DataAccess.Models.Filter(), 1).ToList();
        }

        public IEnumerable<Frapid.WebsiteBuilder.Entities.Menu> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new Frapid.WebsiteBuilder.Entities.Menu(), 1);
        }

        public IEnumerable<Frapid.DataAccess.Models.DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<Frapid.DataAccess.Models.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<Frapid.DataAccess.Models.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic menu, List<Frapid.DataAccess.Models.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic menu, int menuId)
        {
            if (menuId > 0)
            {
                return;
            }

            throw new ArgumentException("menuId is null.");
        }

        public object Add(dynamic menu)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> menus)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int menuId)
        {
            if (menuId > 0)
            {
                return;
            }

            throw new ArgumentException("menuId is null.");
        }


    }
}