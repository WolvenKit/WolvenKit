using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(108)] 
		[RED("useLights")] 
		public CBool UseLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("lightsSettings")] 
		public CArray<EditableGameLightSettings> LightsSettings
		{
			get => GetPropertyValue<CArray<EditableGameLightSettings>>();
			set => SetPropertyValue<CArray<EditableGameLightSettings>>(value);
		}

		[Ordinal(110)] 
		[RED("useDeviceAppearence")] 
		public CBool UseDeviceAppearence
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BillboardDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
