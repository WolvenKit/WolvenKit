using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		private inkWidgetReference _textRoot;
		private inkWidgetReference _background;
		private CHandle<inkanimProxy> _animSelectionBackground;
		private CHandle<inkanimProxy> _animSelectionText;
		private CBool _selectedState;
		private CFloat _animationDuration;

		[Ordinal(16)] 
		[RED("textRoot")] 
		public inkWidgetReference TextRoot
		{
			get
			{
				if (_textRoot == null)
				{
					_textRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "textRoot", cr2w, this);
				}
				return _textRoot;
			}
			set
			{
				if (_textRoot == value)
				{
					return;
				}
				_textRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animSelectionBackground")] 
		public CHandle<inkanimProxy> AnimSelectionBackground
		{
			get
			{
				if (_animSelectionBackground == null)
				{
					_animSelectionBackground = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectionBackground", cr2w, this);
				}
				return _animSelectionBackground;
			}
			set
			{
				if (_animSelectionBackground == value)
				{
					return;
				}
				_animSelectionBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animSelectionText")] 
		public CHandle<inkanimProxy> AnimSelectionText
		{
			get
			{
				if (_animSelectionText == null)
				{
					_animSelectionText = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animSelectionText", cr2w, this);
				}
				return _animSelectionText;
			}
			set
			{
				if (_animSelectionText == value)
				{
					return;
				}
				_animSelectionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("selectedState")] 
		public CBool SelectedState
		{
			get
			{
				if (_selectedState == null)
				{
					_selectedState = (CBool) CR2WTypeManager.Create("Bool", "selectedState", cr2w, this);
				}
				return _selectedState;
			}
			set
			{
				if (_selectedState == value)
				{
					return;
				}
				_selectedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("animationDuration")] 
		public CFloat AnimationDuration
		{
			get
			{
				if (_animationDuration == null)
				{
					_animationDuration = (CFloat) CR2WTypeManager.Create("Float", "animationDuration", cr2w, this);
				}
				return _animationDuration;
			}
			set
			{
				if (_animationDuration == value)
				{
					return;
				}
				_animationDuration = value;
				PropertySet(this);
			}
		}

		public MessangerReplyItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
