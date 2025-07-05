using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioSpatialSoundLimitMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("eventNames")] 
		public CArray<CName> EventNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("writeOnlyEventNames")] 
		public CArray<CName> WriteOnlyEventNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("readOnlyEventNames")] 
		public CArray<CName> ReadOnlyEventNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioSpatialSoundLimitMetadata()
		{
			EventNames = new();
			WriteOnlyEventNames = new();
			ReadOnlyEventNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
