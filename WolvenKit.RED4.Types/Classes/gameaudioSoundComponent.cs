using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioSoundComponent : gameaudioSoundComponentBase
	{
		[Ordinal(11)] 
		[RED("subSystems")] 
		public CArray<gameaudioSoundComponentSubSystemWrapper> SubSystems
		{
			get => GetPropertyValue<CArray<gameaudioSoundComponentSubSystemWrapper>>();
			set => SetPropertyValue<CArray<gameaudioSoundComponentSubSystemWrapper>>(value);
		}

		[Ordinal(12)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("minVocalizationRepeatTime")] 
		public CFloat MinVocalizationRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioSoundComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			ObstructionChangeTime = 0.200000F;
			MaxPlayDistance = 40.000000F;
			SubSystems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
