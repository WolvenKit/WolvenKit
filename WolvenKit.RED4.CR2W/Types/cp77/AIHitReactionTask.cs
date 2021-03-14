using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHitReactionTask : AIbehaviortaskScript
	{
		private CFloat _activationTimeStamp;
		private CFloat _reactionDuration;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;
		private CEnum<animHitReactionType> _hitReactionType;

		[Ordinal(0)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get
			{
				if (_activationTimeStamp == null)
				{
					_activationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "activationTimeStamp", cr2w, this);
				}
				return _activationTimeStamp;
			}
			set
			{
				if (_activationTimeStamp == value)
				{
					return;
				}
				_activationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reactionDuration")] 
		public CFloat ReactionDuration
		{
			get
			{
				if (_reactionDuration == null)
				{
					_reactionDuration = (CFloat) CR2WTypeManager.Create("Float", "reactionDuration", cr2w, this);
				}
				return _reactionDuration;
			}
			set
			{
				if (_reactionDuration == value)
				{
					return;
				}
				_reactionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get
			{
				if (_hitReactionAction == null)
				{
					_hitReactionAction = (CHandle<ActionHitReactionScriptProxy>) CR2WTypeManager.Create("handle:ActionHitReactionScriptProxy", "hitReactionAction", cr2w, this);
				}
				return _hitReactionAction;
			}
			set
			{
				if (_hitReactionAction == value)
				{
					return;
				}
				_hitReactionAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get
			{
				if (_hitReactionType == null)
				{
					_hitReactionType = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "hitReactionType", cr2w, this);
				}
				return _hitReactionType;
			}
			set
			{
				if (_hitReactionType == value)
				{
					return;
				}
				_hitReactionType = value;
				PropertySet(this);
			}
		}

		public AIHitReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
