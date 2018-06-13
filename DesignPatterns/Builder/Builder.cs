using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Builder : IBuilder
    {
        private int count;
        private string strToRepeat;
        private object config;

        public Item CreateItem()
        {
            return new Item
            {
                Value = string.Join("", Enumerable.Repeat(strToRepeat, count)),
                Config = config
            };
        }

        public IBuilder SetFirst(int num)
        {
            count = num;
            return this;
        }

        public IBuilder SetSecond(string str)
        {
            strToRepeat = str;
            return this;
        }

        public IBuilder SetThird(object obj)
        {
            config = obj;
            return this;
        }
    }
}
