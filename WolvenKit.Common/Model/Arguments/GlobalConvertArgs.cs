using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model.Arguments
{
    public class GlobalConvertArgs
    {
        private readonly Dictionary<Type, ConvertArgs> _argsList = new()
        {
            { typeof(CommonConvertArgs), new CommonConvertArgs() },
        };

        public GlobalConvertArgs Register(params ConvertArgs[] convertArgs)
        {
            foreach (var arg in convertArgs)
            {
                var type = arg.GetType();
                if (_argsList.ContainsKey(type))
                {
                    _argsList[type] = arg;
                }
                else
                {
                    _argsList.Add(type, arg);
                }
            }

            return this;
        }

        public T Get<T>() where T : ConvertArgs
        {
            var arg = _argsList[typeof(T)];
            if (arg is T t)
            {
                return t;
            }
            throw new ArgumentException();
        }
    }


}
