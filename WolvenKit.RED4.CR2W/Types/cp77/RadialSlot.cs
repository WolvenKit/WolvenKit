using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialSlot : IScriptable
	{
		private inkWidgetReference _slotAnchorRef;
		private inkWidgetLibraryReference _libraryRef;
		private CEnum<SlotType> _slotType;
		private RadialAnimData _animData;
		private wCHandle<inkWidget> _widget;
		private CFloat _targetAngle;
		private CString _active;
		private CString _inactive;
		private CString _blocked;

		[Ordinal(0)] 
		[RED("slotAnchorRef")] 
		public inkWidgetReference SlotAnchorRef
		{
			get
			{
				if (_slotAnchorRef == null)
				{
					_slotAnchorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotAnchorRef", cr2w, this);
				}
				return _slotAnchorRef;
			}
			set
			{
				if (_slotAnchorRef == value)
				{
					return;
				}
				_slotAnchorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("libraryRef")] 
		public inkWidgetLibraryReference LibraryRef
		{
			get
			{
				if (_libraryRef == null)
				{
					_libraryRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryRef", cr2w, this);
				}
				return _libraryRef;
			}
			set
			{
				if (_libraryRef == value)
				{
					return;
				}
				_libraryRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotType")] 
		public CEnum<SlotType> SlotType
		{
			get
			{
				if (_slotType == null)
				{
					_slotType = (CEnum<SlotType>) CR2WTypeManager.Create("SlotType", "slotType", cr2w, this);
				}
				return _slotType;
			}
			set
			{
				if (_slotType == value)
				{
					return;
				}
				_slotType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animData")] 
		public RadialAnimData AnimData
		{
			get
			{
				if (_animData == null)
				{
					_animData = (RadialAnimData) CR2WTypeManager.Create("RadialAnimData", "animData", cr2w, this);
				}
				return _animData;
			}
			set
			{
				if (_animData == value)
				{
					return;
				}
				_animData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetAngle")] 
		public CFloat TargetAngle
		{
			get
			{
				if (_targetAngle == null)
				{
					_targetAngle = (CFloat) CR2WTypeManager.Create("Float", "targetAngle", cr2w, this);
				}
				return _targetAngle;
			}
			set
			{
				if (_targetAngle == value)
				{
					return;
				}
				_targetAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("active")] 
		public CString Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CString) CR2WTypeManager.Create("String", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inactive")] 
		public CString Inactive
		{
			get
			{
				if (_inactive == null)
				{
					_inactive = (CString) CR2WTypeManager.Create("String", "inactive", cr2w, this);
				}
				return _inactive;
			}
			set
			{
				if (_inactive == value)
				{
					return;
				}
				_inactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("blocked")] 
		public CString Blocked
		{
			get
			{
				if (_blocked == null)
				{
					_blocked = (CString) CR2WTypeManager.Create("String", "blocked", cr2w, this);
				}
				return _blocked;
			}
			set
			{
				if (_blocked == value)
				{
					return;
				}
				_blocked = value;
				PropertySet(this);
			}
		}

		public RadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
