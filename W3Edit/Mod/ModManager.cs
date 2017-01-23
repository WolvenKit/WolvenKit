namespace W3Edit.Mod
{
    public class ModManager
    {
        private static ModManager instance;
        public W3Mod ActiveMod { get; set; }

        public static ModManager Get()
        {
            if (instance == null)
            {
                instance = new ModManager();
            }

            return instance;
        }
    }
}