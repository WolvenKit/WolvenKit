using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeyboardHintItemController : AHintItemController
	{
		private inkTextWidgetReference _numberText;
		private inkImageWidgetReference _frame;
		private CName _disabledStateName;
		private CName _selectedStateName;
		private CName _frameSelectedName;
		private CName _frameUnselectedName;
		private CName _animationName;

		[Ordinal(4)] 
		[RED("NumberText")] 
		public inkTextWidgetReference NumberText
		{
			get
			{
				if (_numberText == null)
				{
					_numberText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NumberText", cr2w, this);
				}
				return _numberText;
			}
			set
			{
				if (_numberText == value)
				{
					return;
				}
				_numberText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Frame")] 
		public inkImageWidgetReference Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("DisabledStateName")] 
		public CName DisabledStateName
		{
			get
			{
				if (_disabledStateName == null)
				{
					_disabledStateName = (CName) CR2WTypeManager.Create("CName", "DisabledStateName", cr2w, this);
				}
				return _disabledStateName;
			}
			set
			{
				if (_disabledStateName == value)
				{
					return;
				}
				_disabledStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("SelectedStateName")] 
		public CName SelectedStateName
		{
			get
			{
				if (_selectedStateName == null)
				{
					_selectedStateName = (CName) CR2WTypeManager.Create("CName", "SelectedStateName", cr2w, this);
				}
				return _selectedStateName;
			}
			set
			{
				if (_selectedStateName == value)
				{
					return;
				}
				_selectedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("FrameSelectedName")] 
		public CName FrameSelectedName
		{
			get
			{
				if (_frameSelectedName == null)
				{
					_frameSelectedName = (CName) CR2WTypeManager.Create("CName", "FrameSelectedName", cr2w, this);
				}
				return _frameSelectedName;
			}
			set
			{
				if (_frameSelectedName == value)
				{
					return;
				}
				_frameSelectedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("FrameUnselectedName")] 
		public CName FrameUnselectedName
		{
			get
			{
				if (_frameUnselectedName == null)
				{
					_frameUnselectedName = (CName) CR2WTypeManager.Create("CName", "FrameUnselectedName", cr2w, this);
				}
				return _frameUnselectedName;
			}
			set
			{
				if (_frameUnselectedName == value)
				{
					return;
				}
				_frameUnselectedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("AnimationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "AnimationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		public KeyboardHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
