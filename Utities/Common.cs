using System;
using System.Collections.Generic;
using System.Text;

namespace Utities
{
    /// <summary>
    /// 共用方法
    /// </summary>
    public class Common
    {
        private int BaseNumber = 2;

        public int GetBaseNumber()
        {
            return BaseNumber + 2;
        }

        public int GetBaseNumberAdd()
        {
            return BaseNumber + 8;
        }
    }
}
