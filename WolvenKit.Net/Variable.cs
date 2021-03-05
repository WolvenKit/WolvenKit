namespace WolvenKit.Net
{
    //These are returned when we recieve from the game 0xFFFFFFFFCC00CC00 aka Varlist
    public class Variable
    {
        #region Fields

        public string byte1;
        public string byte2;

        #endregion Fields

        #region Properties

        public string Section { get; set; }
        public string Value { get; set; }
        public string Varname { get; set; }

        #endregion Properties
    }
}
