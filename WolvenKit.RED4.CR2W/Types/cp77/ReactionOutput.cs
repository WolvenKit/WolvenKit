using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionOutput : CVariable
	{
		private CEnum<gamedataOutput> _reactionBehavior;
		private CInt32 _reactionPriority;
		private CFloat _aIbehaviorPriority;
		private CFloat _reactionCooldown;
		private CBool _startedInWorkspot;
		private CBool _workspotReaction;
		private CName _workspotReactionType;

		[Ordinal(0)] 
		[RED("reactionBehavior")] 
		public CEnum<gamedataOutput> ReactionBehavior
		{
			get
			{
				if (_reactionBehavior == null)
				{
					_reactionBehavior = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "reactionBehavior", cr2w, this);
				}
				return _reactionBehavior;
			}
			set
			{
				if (_reactionBehavior == value)
				{
					return;
				}
				_reactionBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reactionPriority")] 
		public CInt32 ReactionPriority
		{
			get
			{
				if (_reactionPriority == null)
				{
					_reactionPriority = (CInt32) CR2WTypeManager.Create("Int32", "reactionPriority", cr2w, this);
				}
				return _reactionPriority;
			}
			set
			{
				if (_reactionPriority == value)
				{
					return;
				}
				_reactionPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("AIbehaviorPriority")] 
		public CFloat AIbehaviorPriority
		{
			get
			{
				if (_aIbehaviorPriority == null)
				{
					_aIbehaviorPriority = (CFloat) CR2WTypeManager.Create("Float", "AIbehaviorPriority", cr2w, this);
				}
				return _aIbehaviorPriority;
			}
			set
			{
				if (_aIbehaviorPriority == value)
				{
					return;
				}
				_aIbehaviorPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reactionCooldown")] 
		public CFloat ReactionCooldown
		{
			get
			{
				if (_reactionCooldown == null)
				{
					_reactionCooldown = (CFloat) CR2WTypeManager.Create("Float", "reactionCooldown", cr2w, this);
				}
				return _reactionCooldown;
			}
			set
			{
				if (_reactionCooldown == value)
				{
					return;
				}
				_reactionCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("startedInWorkspot")] 
		public CBool StartedInWorkspot
		{
			get
			{
				if (_startedInWorkspot == null)
				{
					_startedInWorkspot = (CBool) CR2WTypeManager.Create("Bool", "startedInWorkspot", cr2w, this);
				}
				return _startedInWorkspot;
			}
			set
			{
				if (_startedInWorkspot == value)
				{
					return;
				}
				_startedInWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("workspotReaction")] 
		public CBool WorkspotReaction
		{
			get
			{
				if (_workspotReaction == null)
				{
					_workspotReaction = (CBool) CR2WTypeManager.Create("Bool", "workspotReaction", cr2w, this);
				}
				return _workspotReaction;
			}
			set
			{
				if (_workspotReaction == value)
				{
					return;
				}
				_workspotReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("workspotReactionType")] 
		public CName WorkspotReactionType
		{
			get
			{
				if (_workspotReactionType == null)
				{
					_workspotReactionType = (CName) CR2WTypeManager.Create("CName", "workspotReactionType", cr2w, this);
				}
				return _workspotReactionType;
			}
			set
			{
				if (_workspotReactionType == value)
				{
					return;
				}
				_workspotReactionType = value;
				PropertySet(this);
			}
		}

		public ReactionOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
