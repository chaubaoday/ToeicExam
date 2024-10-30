using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.SeedWork
{
    public class PagingParameters
    {
        //so trang toi da
        const int maxPageSize = 50;
        //sô trang
        public int PageNumber { get; set; } = 1;
        //so bai thi tren moi trang
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}