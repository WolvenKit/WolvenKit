using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SubmenuDataBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("menuBuilder")] 
		public CHandle<MenuDataBuilder> MenuBuilder
		{
			get => GetPropertyValue<CHandle<MenuDataBuilder>>();
			set => SetPropertyValue<CHandle<MenuDataBuilder>>(value);
		}

		[Ordinal(1)] 
		[RED("menuDataIndex")] 
		public CInt32 MenuDataIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SubmenuDataBuilder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
