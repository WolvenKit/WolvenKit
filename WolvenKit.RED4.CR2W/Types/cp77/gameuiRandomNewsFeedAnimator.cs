using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRandomNewsFeedAnimator : inkWidgetLogicController
	{
		private inkTextWidgetReference _textWidget;
		private CFloat _animDuration;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get
			{
				if (_animDuration == null)
				{
					_animDuration = (CFloat) CR2WTypeManager.Create("Float", "animDuration", cr2w, this);
				}
				return _animDuration;
			}
			set
			{
				if (_animDuration == value)
				{
					return;
				}
				_animDuration = value;
				PropertySet(this);
			}
		}

		public gameuiRandomNewsFeedAnimator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
