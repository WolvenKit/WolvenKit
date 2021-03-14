using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadActionEvent : redEvent
	{
		private CName _squadActionName;
		private CEnum<EAISquadVerb> _squadVerb;

		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CName SquadActionName
		{
			get
			{
				if (_squadActionName == null)
				{
					_squadActionName = (CName) CR2WTypeManager.Create("CName", "squadActionName", cr2w, this);
				}
				return _squadActionName;
			}
			set
			{
				if (_squadActionName == value)
				{
					return;
				}
				_squadActionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("squadVerb")] 
		public CEnum<EAISquadVerb> SquadVerb
		{
			get
			{
				if (_squadVerb == null)
				{
					_squadVerb = (CEnum<EAISquadVerb>) CR2WTypeManager.Create("EAISquadVerb", "squadVerb", cr2w, this);
				}
				return _squadVerb;
			}
			set
			{
				if (_squadVerb == value)
				{
					return;
				}
				_squadVerb = value;
				PropertySet(this);
			}
		}

		public SquadActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
