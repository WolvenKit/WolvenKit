using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScreenDefinitionPackage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public CHandle<gamedataDeviceUIDefinition_Record> ScreenDefinition
		{
			get => GetPropertyValue<CHandle<gamedataDeviceUIDefinition_Record>>();
			set => SetPropertyValue<CHandle<gamedataDeviceUIDefinition_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public CHandle<gamedataWidgetStyle_Record> Style
		{
			get => GetPropertyValue<CHandle<gamedataWidgetStyle_Record>>();
			set => SetPropertyValue<CHandle<gamedataWidgetStyle_Record>>(value);
		}

		public ScreenDefinitionPackage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
