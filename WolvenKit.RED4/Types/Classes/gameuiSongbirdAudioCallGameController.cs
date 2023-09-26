using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSongbirdAudioCallGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("waveformEnabled")] 
		public CBool WaveformEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("voLevelsUpdateTimer")] 
		public CFloat VoLevelsUpdateTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("intensityMultiplier")] 
		public CFloat IntensityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public gameuiSongbirdAudioCallGameController()
		{
			WaveformEnabled = true;
			VoLevelsUpdateTimer = 0.100000F;
			IntensityMultiplier = 10.000000F;
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
