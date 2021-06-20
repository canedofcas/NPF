using Npf.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Npf.Api.Helper
{
    public static class Helpers
    {

        public static IEnumerable<ResultModel> IsMultipleOfEleven( Number num)
        {

            List<ResultModel> lista = new List<ResultModel>();
            foreach (var item in num.Num)
            {
                var digit = 0;
                var res = 0;
                var value = 0;
                var tam = 0;
                var result = 0;

                value = item;
                while (value.ToString().Length > 2)
                {
                    tam = (value / 10);
                    digit = value % 10;
                    res = tam - digit;
                    value = res;
                }
                result = res % 11;

                if (result > 0)
                    lista.Add(new ResultModel { Number = item, isMultiple = false });
                else
                    lista.Add(new ResultModel { Number = item, isMultiple = true });
            }

            return lista;
        }
    }
}
