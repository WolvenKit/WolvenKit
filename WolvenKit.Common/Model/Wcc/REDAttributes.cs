namespace WolvenKit.Common.Wcc
{
    /// <summary>
    /// Custom Attributes to tag properties in the wcc_lite command task.
    /// </summary>

    #region Custom Attributes

    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class REDName : System.Attribute
    {
        #region Fields

        public string name;

        #endregion Fields

        #region Constructors

        public REDName(string name)
        {
            this.name = name;
        }

        #endregion Constructors
    }

    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class REDTags : System.Attribute
    {
        #region Fields

        public string[] tag;

        #endregion Fields

        #region Constructors

        public REDTags(params string[] tag)
        {
            this.tag = tag;
        }

        #endregion Constructors
    }

    #endregion Custom Attributes
}
