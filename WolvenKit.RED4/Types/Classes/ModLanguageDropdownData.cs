
namespace WolvenKit.RED4.Types
{
	public abstract partial class ModLanguageDropdownData : IScriptable
	{
		public ModLanguageDropdownData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
