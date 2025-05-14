using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Proxy
{
    internal interface IBookService
    {


        void DisplayBookInfo(int bookId);
        bool BorrowBook(int bookId, User user);

    }
}






