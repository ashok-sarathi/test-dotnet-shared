using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Helpers.Extentions
{
    public static class ExtensionHelper
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool statement, Expression<Func<T, bool>> predicate)
        {
            return statement ? query.Where(predicate) : query;
        }
    }
}
