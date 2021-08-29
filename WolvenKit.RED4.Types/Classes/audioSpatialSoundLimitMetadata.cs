using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioSpatialSoundLimitMetadata : audioAudioMetadata
	{
		private CArray<CName> _eventNames;
		private CArray<CName> _writeOnlyEventNames;
		private CArray<CName> _readOnlyEventNames;
		private CFloat _radius;

		[Ordinal(1)] 
		[RED("eventNames")] 
		public CArray<CName> EventNames
		{
			get => GetProperty(ref _eventNames);
			set => SetProperty(ref _eventNames, value);
		}

		[Ordinal(2)] 
		[RED("writeOnlyEventNames")] 
		public CArray<CName> WriteOnlyEventNames
		{
			get => GetProperty(ref _writeOnlyEventNames);
			set => SetProperty(ref _writeOnlyEventNames, value);
		}

		[Ordinal(3)] 
		[RED("readOnlyEventNames")] 
		public CArray<CName> ReadOnlyEventNames
		{
			get => GetProperty(ref _readOnlyEventNames);
			set => SetProperty(ref _readOnlyEventNames, value);
		}

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}
	}
}
