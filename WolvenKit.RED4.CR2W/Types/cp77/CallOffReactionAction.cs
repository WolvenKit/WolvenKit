using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallOffReactionAction : SquadTask
	{
		private CEnum<EAISquadAction> _squadActionName;

		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CEnum<EAISquadAction> SquadActionName
		{
			get
			{
				if (_squadActionName == null)
				{
					_squadActionName = (CEnum<EAISquadAction>) CR2WTypeManager.Create("EAISquadAction", "squadActionName", cr2w, this);
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

		public CallOffReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
