using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHostJoinedSquad : AIAIEvent
	{
		private CName _squad;

		[Ordinal(2)] 
		[RED("squad")] 
		public CName Squad
		{
			get
			{
				if (_squad == null)
				{
					_squad = (CName) CR2WTypeManager.Create("CName", "squad", cr2w, this);
				}
				return _squad;
			}
			set
			{
				if (_squad == value)
				{
					return;
				}
				_squad = value;
				PropertySet(this);
			}
		}

		public AIHostJoinedSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
