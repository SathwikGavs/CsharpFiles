﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectG.Day8
{
    internal class BoxA<T>
    {
        List<T> myList = new List<T>();
        public void FillList(T data)
        {
            myList.Add(data);
        }
        public List<T> GetList()
        {
            return myList;
        }
    }
}
