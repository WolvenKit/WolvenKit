using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionTriggerEvent : redEvent
	{
		private CString _item;
		private CFloat _offset;
		private CFloat _adsOffset;
		private CFloat _timeToScan;
		private entEntityID _inspectedObjID;

		[Ordinal(0)] 
		[RED("item")] 
		public CString Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(2)] 
		[RED("adsOffset")] 
		public CFloat AdsOffset
		{
			get => GetProperty(ref _adsOffset);
			set => SetProperty(ref _adsOffset, value);
		}

		[Ordinal(3)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get => GetProperty(ref _timeToScan);
			set => SetProperty(ref _timeToScan, value);
		}

		[Ordinal(4)] 
		[RED("inspectedObjID")] 
		public entEntityID InspectedObjID
		{
			get => GetProperty(ref _inspectedObjID);
			set => SetProperty(ref _inspectedObjID, value);
		}

		public InspectionTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
