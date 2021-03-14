using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameWidget;
		private inkTextWidgetReference _scoreWidget;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkTextWidgetReference NameWidget
		{
			get
			{
				if (_nameWidget == null)
				{
					_nameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameWidget", cr2w, this);
				}
				return _nameWidget;
			}
			set
			{
				if (_nameWidget == value)
				{
					return;
				}
				_nameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scoreWidget")] 
		public inkTextWidgetReference ScoreWidget
		{
			get
			{
				if (_scoreWidget == null)
				{
					_scoreWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scoreWidget", cr2w, this);
				}
				return _scoreWidget;
			}
			set
			{
				if (_scoreWidget == value)
				{
					return;
				}
				_scoreWidget = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerScoreRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
