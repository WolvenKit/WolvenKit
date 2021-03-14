using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetSlotAttachmentParams : CVariable
	{
		private CName _slotID;
		private CBool _useSlotLayout;
		private inkWidgetLayout _layoutOverride;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("useSlotLayout")] 
		public CBool UseSlotLayout
		{
			get
			{
				if (_useSlotLayout == null)
				{
					_useSlotLayout = (CBool) CR2WTypeManager.Create("Bool", "useSlotLayout", cr2w, this);
				}
				return _useSlotLayout;
			}
			set
			{
				if (_useSlotLayout == value)
				{
					return;
				}
				_useSlotLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("layoutOverride")] 
		public inkWidgetLayout LayoutOverride
		{
			get
			{
				if (_layoutOverride == null)
				{
					_layoutOverride = (inkWidgetLayout) CR2WTypeManager.Create("inkWidgetLayout", "layoutOverride", cr2w, this);
				}
				return _layoutOverride;
			}
			set
			{
				if (_layoutOverride == value)
				{
					return;
				}
				_layoutOverride = value;
				PropertySet(this);
			}
		}

		public inkWidgetSlotAttachmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
