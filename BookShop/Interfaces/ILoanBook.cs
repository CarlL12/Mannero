using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Interfaces
{
    public interface ILoanBook : IBook
    {
        int DueDate { get; set; }
    }
}
