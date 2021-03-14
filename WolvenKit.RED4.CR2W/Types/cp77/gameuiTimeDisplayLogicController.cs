using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTimeDisplayLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _timerText;
		private inkTextWidgetReference _noConnectionText;

		[Ordinal(1)] 
		[RED("timerText")] 
		public inkTextWidgetReference TimerText
		{
			get
			{
				if (_timerText == null)
				{
					_timerText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timerText", cr2w, this);
				}
				return _timerText;
			}
			set
			{
				if (_timerText == value)
				{
					return;
				}
				_timerText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("noConnectionText")] 
		public inkTextWidgetReference NoConnectionText
		{
			get
			{
				if (_noConnectionText == null)
				{
					_noConnectionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "noConnectionText", cr2w, this);
				}
				return _noConnectionText;
			}
			set
			{
				if (_noConnectionText == value)
				{
					return;
				}
				_noConnectionText = value;
				PropertySet(this);
			}
		}

		public gameuiTimeDisplayLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
