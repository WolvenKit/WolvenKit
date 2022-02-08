using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkClippedMenuScenarioData : IScriptable
	{
		[Ordinal(0)] 
		[RED("menus")] 
		public CArray<CName> Menus
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public inkClippedMenuScenarioData()
		{
			Menus = new();
		}
	}
}
