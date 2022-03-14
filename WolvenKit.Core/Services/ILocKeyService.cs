using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface ILocKeyService
    {
        public string Language { get; set; }

        public string GetFemaleVariant(ulong key);

        public string GetFemaleVariant(string key);

        public string GetMaleVariant(ulong key);

        public string GetMaleVariant(string key);
    }
}
