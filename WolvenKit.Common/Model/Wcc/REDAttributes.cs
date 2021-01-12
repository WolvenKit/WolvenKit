using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WolvenKit.Common.Wcc
{
    /// <summary>
    /// Custom Attributes to tag properties in the wcc_lite command task.
    /// </summary>
    #region Custom Attributes
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class REDTags : System.Attribute
    {
        public string[] tag;
        public REDTags(params string[] tag)
        {
            this.tag = tag;
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class REDName : System.Attribute
    {
        public string name;
        public REDName(string name)
        {
            this.name = name;
        }
    }

    #endregion


}
