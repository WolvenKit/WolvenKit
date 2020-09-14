using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace WolvenKit.Common.Wcc
{
    #region Wcc_lite Command class
    public abstract class WCC_Command
    {
        [Browsable(false)]
        public string Name { get; set; }

        #region Properties

        [CategoryAttribute("0 INFO")]
        [ReadOnly(true)]
        [Browsable(false)]
        public string Arguments => ConstructArgs();

        #endregion

        #region Overrides
        public override string ToString() => Name;
        #endregion

        #region Methods
        /// <summary>
        /// Runs the wcc lite command
        /// </summary>
        /// <returns></returns>
        public EWccStatus Run() => EWccStatus.Finished;
        /// <summary>
        /// returns a string constructed from the variables of the wcc_lite command class
        /// </summary>
        /// <returns>string commandline arguments</returns>
        private string ConstructArgs()
        {
            var strVariables = GetVariables();
            string procArgs = ToString() + " ";

            foreach (KeyValuePair<string, string> str in strVariables)
            {
                if (str.Key.Equals("HIDDEN") || string.IsNullOrEmpty(str.Key))
                {
                    procArgs += $"{str.Value} ";
                }
                else
                {
                    procArgs += $"-{str.Key}{str.Value} ";
                }
            }

            return procArgs;
        }

        /// <summary>
        /// returns all variables as dictionary.
        /// </summary>
        /// <returns> Dictionary<string,string> </returns>
        private Dictionary<string, string> GetVariables() //TODO: Cleanup
        {
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public;
            var dict = new Dictionary<string, string>();

            //get all properties with a RADName
            IEnumerable<PropertyInfo> REDarguments = this.GetType().GetProperties(bindingFlags);
            foreach (var pi in REDarguments)
            {
                // initial check
                //check RADName attribute
                REDName REDatt = (REDName)Attribute.GetCustomAttribute(pi, typeof(REDName));
                if (REDatt == null || string.IsNullOrEmpty(REDatt.name))
                {
                    continue;
                }
                //check values
                var val = Convert.ToString(pi.GetValue(this));
                if (string.IsNullOrEmpty(val) || (pi.PropertyType == typeof(bool) && !bool.Parse((string)val)))
                {
                    continue;
                }

                string nam = REDatt.name;

                //Strings
                if (pi.PropertyType == typeof(string))
                {
                    REDTags tag = (REDTags)Attribute.GetCustomAttribute(pi, typeof(REDTags));

                    // Paths
                    if (Attribute.GetCustomAttributes(pi).Any(x => (x is REDTags))
                        && tag.tag.Contains("Path")
                        && val.First() != '"') //check for alrady declared paths
                    {

                        if (Path.GetExtension(val) == "") //is a directory
                        {
                            val = Path.GetFullPath(val).ToString() + "\\";
                            val = val.Replace(@"\", @"\\"); //FIXME? it's stupid but seems to work
                        }
                        val = $"=\"{val}\"";
                        //The end of the atomic dumpfile horror :
                        if (val == "=\"\\\\\\\\?\\\\\\\\\"") val = "=" + @"\\?\";
                    }
                    // other strings
                    else
                    {
                        val = $"={val}";
                    }
                }
                else if (pi.PropertyType == typeof(bool))
                {
                    val = "";
                }
                else
                {
                    if (val == "None")
                    {
                        continue;
                    }
                    else
                    {
                        REDTags tag = (REDTags)Attribute.GetCustomAttribute(pi, typeof(REDTags));

                        // keywords only have values (e.g. analyze r4gui -out=)
                        if (tag != null && tag.tag.Contains("Keyword"))
                        {
                            nam = "HIDDEN";
                        }
                        else
                        {
                            val = $"=\"{val}\"";
                        }
                    }
                }

                dict.Add(nam, val);
            }
            return dict;
        }

        /// <summary>
        /// Function to pass the outfile variable - if existing. 
        /// </summary>
        private string GetOutfile()
        {
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            string ret = "";

            foreach (PropertyInfo prop in this.GetType().GetProperties(bindingFlags).Where(x => x.Name.Equals("outfile")))
            {
                var val = Convert.ToString(prop.GetValue(this));
                if (prop.PropertyType == typeof(string) && !string.IsNullOrEmpty(val))
                    ret = val;
            }
            return ret;
        }
        #endregion

    }
    #endregion



}
