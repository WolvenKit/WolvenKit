using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
