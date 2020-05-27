using System;
using System.Collections.Generic;
using System.Text;

namespace Utities.NetTools
{
    public interface IRestSharp
    {
        /// <summary>
        /// Get方法呼叫API
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        string Get(string url);
    }
}
