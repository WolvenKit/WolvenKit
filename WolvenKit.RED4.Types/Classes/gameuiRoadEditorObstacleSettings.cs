using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoadEditorObstacleSettings : RedBaseClass
	{
		private CName _libraryName;
		private CFloat _offset;
		private CFloat _speed;
		private CUInt32 _segmentOffset;

		[Ordinal(0)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetProperty(ref _libraryName);
			set => SetProperty(ref _libraryName, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(3)] 
		[RED("segmentOffset")] 
		public CUInt32 SegmentOffset
		{
			get => GetProperty(ref _segmentOffset);
			set => SetProperty(ref _segmentOffset, value);
		}
	}
}
