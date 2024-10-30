using Examination.Shared.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.Categories
{
   //chua cac tham so tim kiem
    public class CategorySearch : PagingParameters
    {
        public string Name { get; set; }
    }
}