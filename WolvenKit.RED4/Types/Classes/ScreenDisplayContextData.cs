using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScreenDisplayContextData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Context")] 
		public CEnum<ScreenDisplayContext> Context
		{
			get => GetPropertyValue<CEnum<ScreenDisplayContext>>();
			set => SetPropertyValue<CEnum<ScreenDisplayContext>>(value);
		}

		public ScreenDisplayContextData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
