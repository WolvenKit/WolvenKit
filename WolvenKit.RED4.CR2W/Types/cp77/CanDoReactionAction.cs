using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanDoReactionAction : AIbehaviorconditionScript
	{
		private CName _reactionName;

		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get
			{
				if (_reactionName == null)
				{
					_reactionName = (CName) CR2WTypeManager.Create("CName", "reactionName", cr2w, this);
				}
				return _reactionName;
			}
			set
			{
				if (_reactionName == value)
				{
					return;
				}
				_reactionName = value;
				PropertySet(this);
			}
		}

		public CanDoReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
