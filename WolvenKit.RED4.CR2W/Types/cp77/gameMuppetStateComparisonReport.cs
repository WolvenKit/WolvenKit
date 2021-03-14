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
			get
			{
				if (_frameID == null)
				{
					_frameID = (CUInt32) CR2WTypeManager.Create("Uint32", "frameID", cr2w, this);
				}
				return _frameID;
			}
			set
			{
				if (_frameID == value)
				{
					return;
				}
				_frameID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameMuppetComparisonReportItem> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<gameMuppetComparisonReportItem>) CR2WTypeManager.Create("array:gameMuppetComparisonReportItem", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public gameMuppetStateComparisonReport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
