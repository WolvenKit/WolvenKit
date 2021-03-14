using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterReactionAction : AIbehaviortaskScript
	{
		private CName _reactionName;
		private CBool _onDeactivation;

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

		[Ordinal(1)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get
			{
				if (_onDeactivation == null)
				{
					_onDeactivation = (CBool) CR2WTypeManager.Create("Bool", "onDeactivation", cr2w, this);
				}
				return _onDeactivation;
			}
			set
			{
				if (_onDeactivation == value)
				{
					return;
				}
				_onDeactivation = value;
				PropertySet(this);
			}
		}

		public UnregisterReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
