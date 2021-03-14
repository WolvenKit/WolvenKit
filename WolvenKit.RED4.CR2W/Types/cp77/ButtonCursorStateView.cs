using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonCursorStateView : BaseButtonView
	{
		private CName _hoverStateName;
		private CName _pressStateName;
		private CName _defaultStateName;

		[Ordinal(2)] 
		[RED("HoverStateName")] 
		public CName HoverStateName
		{
			get
			{
				if (_hoverStateName == null)
				{
					_hoverStateName = (CName) CR2WTypeManager.Create("CName", "HoverStateName", cr2w, this);
				}
				return _hoverStateName;
			}
			set
			{
				if (_hoverStateName == value)
				{
					return;
				}
				_hoverStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PressStateName")] 
		public CName PressStateName
		{
			get
			{
				if (_pressStateName == null)
				{
					_pressStateName = (CName) CR2WTypeManager.Create("CName", "PressStateName", cr2w, this);
				}
				return _pressStateName;
			}
			set
			{
				if (_pressStateName == value)
				{
					return;
				}
				_pressStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get
			{
				if (_defaultStateName == null)
				{
					_defaultStateName = (CName) CR2WTypeManager.Create("CName", "DefaultStateName", cr2w, this);
				}
				return _defaultStateName;
			}
			set
			{
				if (_defaultStateName == value)
				{
					return;
				}
				_defaultStateName = value;
				PropertySet(this);
			}
		}

		public ButtonCursorStateView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
