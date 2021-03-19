using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetInspectMode_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CString _objectID;
		private CFloat _startingOffset;
		private CFloat _zoomOffset;
		private CFloat _timeInterval;

		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get => GetProperty(ref _objectID);
			set => SetProperty(ref _objectID, value);
		}

		[Ordinal(1)] 
		[RED("startingOffset")] 
		public CFloat StartingOffset
		{
			get => GetProperty(ref _startingOffset);
			set => SetProperty(ref _startingOffset, value);
		}

		[Ordinal(2)] 
		[RED("zoomOffset")] 
		public CFloat ZoomOffset
		{
			get => GetProperty(ref _zoomOffset);
			set => SetProperty(ref _zoomOffset, value);
		}

		[Ordinal(3)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		public questSetInspectMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
