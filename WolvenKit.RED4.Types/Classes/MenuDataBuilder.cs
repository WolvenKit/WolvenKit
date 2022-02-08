using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuDataBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<MenuData> Data
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		public MenuDataBuilder()
		{
			Data = new();
		}
	}
}
