using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("jukeboxSetup")] 
		public JukeboxSetup JukeboxSetup
		{
			get => GetPropertyValue<JukeboxSetup>();
			set => SetPropertyValue<JukeboxSetup>(value);
		}

		[Ordinal(108)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(109)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public JukeboxControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
