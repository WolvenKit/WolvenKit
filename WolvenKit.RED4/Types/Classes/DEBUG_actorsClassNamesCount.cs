using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_actorsClassNamesCount : IScriptable
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public DEBUG_actorsClassNamesCount()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
