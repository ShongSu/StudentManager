using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;

namespace Languages
{
    public class Language
    {
        private static ResourceManager m_RM =
            new ResourceManager("Languages.Language",
            Assembly.GetExecutingAssembly());

        /// <summary>
        /// 根据指定标识字符串获取其多语言字符串
        /// </summary>
        /// <param name="str">标识字符串</param>
        /// <returns>多语言字符串</returns>
        public static string GetString(string str)
        {
            string ret = "";
            try
            {
                m_RM.IgnoreCase = true;
                ret = m_RM.GetString(str);

                if (string.IsNullOrEmpty(ret) || string.IsNullOrWhiteSpace(ret))
                {
                    ret = m_RM.GetString("Unknown");
                }
            }
            catch (Exception ex)
            {
                ret = str;
            }

            return ret;
        }
    }
}
