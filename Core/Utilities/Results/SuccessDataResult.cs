using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        //ctor
        //Base : DataResult
        public SuccessDataResult(T data, string message) : base(data, true, message) //islem sonucunu default true verdik
        {

        }

        public SuccessDataResult(T data) : base(data, true) //mesaj vermedi
        {

        }

        public SuccessDataResult(string message) : base(default, true, message) // sadece mesaj
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }

    }
}
