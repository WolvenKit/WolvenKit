using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkIWidgetSlotController : inkWidgetLogicController
	{
		private CName _slotID;
		private inkWidgetLayout _layout;

		[Ordinal(1)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CName) CR2WTypeManager.Create("CName", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get
			{
				if (_layout == null)
				{
					_layout = (inkWidgetLayout) CR2WTypeManager.Create("inkWidgetLayout", "layout", cr2w, this);
				}
				return _layout;
			}
			set
			{
				if (_layout == value)
				{
					return;
				}
				_layout = value;
				PropertySet(this);
			}
		}

		public inkIWidgetSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
