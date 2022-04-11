using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("jukeboxSetup")] 
		public JukeboxSetup JukeboxSetup
		{
			get => GetPropertyValue<JukeboxSetup>();
			set => SetPropertyValue<JukeboxSetup>(value);
		}

		[Ordinal(105)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetPropertyValue<CArray<RadioStationsMap>>();
			set => SetPropertyValue<CArray<RadioStationsMap>>(value);
		}

		[Ordinal(106)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(107)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public JukeboxControllerPS()
		{
			DeviceName = "LocKey#165";
			TweakDBRecord = 65591369476;
			TweakDBDescriptionRecord = 116534778712;
			JukeboxSetup = new();
			Stations = new();
			IsPlaying = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
