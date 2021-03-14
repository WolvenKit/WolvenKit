using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialBracketShowEvent : redEvent
	{
		private gameTutorialBracketData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gameTutorialBracketData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameTutorialBracketData) CR2WTypeManager.Create("gameTutorialBracketData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialBracketShowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
