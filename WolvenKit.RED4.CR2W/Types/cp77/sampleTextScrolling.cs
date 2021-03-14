using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTextScrolling : inkWidgetLogicController
	{
		private inkTextWidgetReference _scrollingText;
		private inkanimPlaybackOptions _infiniteloop;

		[Ordinal(1)] 
		[RED("scrollingText")] 
		public inkTextWidgetReference ScrollingText
		{
			get
			{
				if (_scrollingText == null)
				{
					_scrollingText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scrollingText", cr2w, this);
				}
				return _scrollingText;
			}
			set
			{
				if (_scrollingText == value)
				{
					return;
				}
				_scrollingText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("infiniteloop")] 
		public inkanimPlaybackOptions Infiniteloop
		{
			get
			{
				if (_infiniteloop == null)
				{
					_infiniteloop = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "infiniteloop", cr2w, this);
				}
				return _infiniteloop;
			}
			set
			{
				if (_infiniteloop == value)
				{
					return;
				}
				_infiniteloop = value;
				PropertySet(this);
			}
		}

		public sampleTextScrolling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
