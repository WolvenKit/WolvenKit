using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateComparisonReport : CVariable
	{
		private CUInt32 _frameID;
		private CArray<gameMuppetComparisonReportItem> _items;

		[Ordinal(0)] 
		[RED("frameID")] 
		public CUInt32 FrameID
		{
			get => GetProperty(ref _frameID);
			set => SetProperty(ref _frameID, value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameMuppetComparisonReportItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public gameMuppetStateComparisonReport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
