using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsPositionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _namesText;

		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("namesText")] 
		public inkTextWidgetReference NamesText
		{
			get
			{
				if (_namesText == null)
				{
					_namesText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "namesText", cr2w, this);
				}
				return _namesText;
			}
			set
			{
				if (_namesText == value)
				{
					return;
				}
				_namesText = value;
				PropertySet(this);
			}
		}

		public gameuiCreditsPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
