using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BillboardDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CName _glitchSFX;
		private CBool _useLights;
		private CArray<EditableGameLightSettings> _lightsSettings;
		private CBool _useDeviceAppearence;

		[Ordinal(104)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		[Ordinal(105)] 
		[RED("useLights")] 
		public CBool UseLights
		{
			get => GetProperty(ref _useLights);
			set => SetProperty(ref _useLights, value);
		}

		[Ordinal(106)] 
		[RED("lightsSettings")] 
		public CArray<EditableGameLightSettings> LightsSettings
		{
			get => GetProperty(ref _lightsSettings);
			set => SetProperty(ref _lightsSettings, value);
		}

		[Ordinal(107)] 
		[RED("useDeviceAppearence")] 
		public CBool UseDeviceAppearence
		{
			get => GetProperty(ref _useDeviceAppearence);
			set => SetProperty(ref _useDeviceAppearence, value);
		}

		public BillboardDeviceControllerPS()
		{
			_glitchSFX = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110";
			_useLights = true;
			_useDeviceAppearence = true;
		}
	}
}
