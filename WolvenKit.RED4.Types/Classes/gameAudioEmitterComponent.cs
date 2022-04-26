using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAudioEmitterComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("EmitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("EmitterType")] 
		public CEnum<audioEntityEmitterContextType> EmitterType
		{
			get => GetPropertyValue<CEnum<audioEntityEmitterContextType>>();
			set => SetPropertyValue<CEnum<audioEntityEmitterContextType>>(value);
		}

		[Ordinal(7)] 
		[RED("OnAttach")] 
		public gameAudioSyncs OnAttach
		{
			get => GetPropertyValue<gameAudioSyncs>();
			set => SetPropertyValue<gameAudioSyncs>(value);
		}

		[Ordinal(8)] 
		[RED("OnDetach")] 
		public gameAudioSyncs OnDetach
		{
			get => GetPropertyValue<gameAudioSyncs>();
			set => SetPropertyValue<gameAudioSyncs>(value);
		}

		[Ordinal(9)] 
		[RED("updateDistance")] 
		public CFloat UpdateDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(12)] 
		[RED("TagList")] 
		public redTagList TagList
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public gameAudioEmitterComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			OnAttach = new() { SwitchEvents = new(), PlayEvents = new(), StopEvents = new(), ParameterEvents = new() };
			OnDetach = new() { SwitchEvents = new(), PlayEvents = new(), StopEvents = new(), ParameterEvents = new() };
			UpdateDistance = 100.000000F;
			Tags = new();
			TagList = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
