using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace NHibernateClassGenerator.Helpers
{
    public class ControlThreadHelper
    {
        public delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        public static void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        public delegate void ExecuteMethodCallback(Control control, string method);
      
        public delegate void ExecuteMethodWithParamCallback(Control control, string method, params object[] param);

        public static void ExecuteMethod(Control controle, string method)
        {
            if (controle.InvokeRequired)
            {
                ExecuteMethodCallback exc = new ExecuteMethodCallback(ExecuteMethod);
                controle.Invoke(exc, new object[] { controle, method });
            }
            else
            {
                Type t = controle.GetType();
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    if (m.Name.ToUpper() == method.ToUpper())
                    {
                        m.Invoke(controle, null);
                    }
                }
            }
        }

        public static void ExecuteMethodWithParam(Control controle, string method, params object[] param)
        {
            if (controle.InvokeRequired)
            {
                ExecuteMethodWithParamCallback exc = new ExecuteMethodWithParamCallback(ExecuteMethodWithParam);
                controle.Invoke(exc, new object[] { controle, method, param });
            }
            else
            {
                Type t = controle.GetType();
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    if (m.Name.ToUpper() == method.ToUpper())
                        if (m.GetParameters().Count() == param.Count())
                            m.Invoke(controle, param);
                }
            }
        }
    }
}
