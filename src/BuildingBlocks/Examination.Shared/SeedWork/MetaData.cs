using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.SeedWork
{
    //dung de hien thi thong tin lien quan den phan trang
    public class MetaData
    {
        //trang hien tai
        public int CurrentPage { get; set; }
        //tong so trang
        public int TotalPages { get; set; }
        //so bai thi tre moi trang
        public int PageSize { get; set; }
        //tong so muc tren tat ca cac trang
        public long TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
