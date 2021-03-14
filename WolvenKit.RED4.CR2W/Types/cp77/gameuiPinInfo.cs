using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPinInfo : CVariable
	{
		private CBool _shouldShow;
		private CBool _showFloorAbove;
		private CBool _showFloorBelow;
		private CInt32 _iconType;
		private CFloat _offset;
		private CString _displayText;

		[Ordinal(0)] 
		[RED("shouldShow")] 
		public CBool ShouldShow
		{
			get
			{
				if (_shouldShow == null)
				{
					_shouldShow = (CBool) CR2WTypeManager.Create("Bool", "shouldShow", cr2w, this);
				}
				return _shouldShow;
			}
			set
			{
				if (_shouldShow == value)
				{
					return;
				}
				_shouldShow = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showFloorAbove")] 
		public CBool ShowFloorAbove
		{
			get
			{
				if (_showFloorAbove == null)
				{
					_showFloorAbove = (CBool) CR2WTypeManager.Create("Bool", "showFloorAbove", cr2w, this);
				}
				return _showFloorAbove;
			}
			set
			{
				if (_showFloorAbove == value)
				{
					return;
				}
				_showFloorAbove = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("showFloorBelow")] 
		public CBool ShowFloorBelow
		{
			get
			{
				if (_showFloorBelow == null)
				{
					_showFloorBelow = (CBool) CR2WTypeManager.Create("Bool", "showFloorBelow", cr2w, this);
				}
				return _showFloorBelow;
			}
			set
			{
				if (_showFloorBelow == value)
				{
					return;
				}
				_showFloorBelow = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconType")] 
		public CInt32 IconType
		{
			get
			{
				if (_iconType == null)
				{
					_iconType = (CInt32) CR2WTypeManager.Create("Int32", "iconType", cr2w, this);
				}
				return _iconType;
			}
			set
			{
				if (_iconType == value)
				{
					return;
				}
				_iconType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("displayText")] 
		public CString DisplayText
		{
			get
			{
				if (_displayText == null)
				{
					_displayText = (CString) CR2WTypeManager.Create("String", "displayText", cr2w, this);
				}
				return _displayText;
			}
			set
			{
				if (_displayText == value)
				{
					return;
				}
				_displayText = value;
				PropertySet(this);
			}
		}

		public gameuiPinInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
