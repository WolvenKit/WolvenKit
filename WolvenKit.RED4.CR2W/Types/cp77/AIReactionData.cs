using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIReactionData : IScriptable
	{
		private CInt32 _reactionPriority;
		private CEnum<gamedataOutput> _reactionBehaviorName;
		private CFloat _reactionBehaviorAIPriority;
		private CFloat _reactionCooldown;
		private wCHandle<gameObject> _stimTarget;
		private Vector4 _stimSource;
		private CEnum<gamedataStimType> _stimType;
		private CEnum<gamedataStimPriority> _stimPriority;
		private CHandle<senseStimuliData> _stimData;
		private stimInvestigateData _stimInvestigateData;
		private StimEventData _stimEventData;
		private CBool _initAnimInWorkspot;
		private CFloat _validTillTimeStamp;
		private CFloat _recentReactionTimeStamp;
		private CBool _escalateProvoke;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("reactionBehaviorName")] 
		public CEnum<gamedataOutput> ReactionBehaviorName
		{
			get
			{
				if (_reactionBehaviorName == null)
				{
					_reactionBehaviorName = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "reactionBehaviorName", cr2w, this);
				}
				return _reactionBehaviorName;
			}
			set
			{
				if (_reactionBehaviorName == value)
				{
					return;
				}
				_reactionBehaviorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorAIPriority")] 
		public CFloat ReactionBehaviorAIPriority
		{
			get
			{
				if (_reactionBehaviorAIPriority == null)
				{
					_reactionBehaviorAIPriority = (CFloat) CR2WTypeManager.Create("Float", "reactionBehaviorAIPriority", cr2w, this);
				}
				return _reactionBehaviorAIPriority;
			}
			set
			{
				if (_reactionBehaviorAIPriority == value)
				{
					return;
				}
				_reactionBehaviorAIPriority = value;
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
		[RED("stimTarget")] 
		public wCHandle<gameObject> StimTarget
		{
			get
			{
				if (_stimTarget == null)
				{
					_stimTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "stimTarget", cr2w, this);
				}
				return _stimTarget;
			}
			set
			{
				if (_stimTarget == value)
				{
					return;
				}
				_stimTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stimSource")] 
		public Vector4 StimSource
		{
			get
			{
				if (_stimSource == null)
				{
					_stimSource = (Vector4) CR2WTypeManager.Create("Vector4", "stimSource", cr2w, this);
				}
				return _stimSource;
			}
			set
			{
				if (_stimSource == value)
				{
					return;
				}
				_stimSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stimPriority")] 
		public CEnum<gamedataStimPriority> StimPriority
		{
			get
			{
				if (_stimPriority == null)
				{
					_stimPriority = (CEnum<gamedataStimPriority>) CR2WTypeManager.Create("gamedataStimPriority", "stimPriority", cr2w, this);
				}
				return _stimPriority;
			}
			set
			{
				if (_stimPriority == value)
				{
					return;
				}
				_stimPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stimData")] 
		public CHandle<senseStimuliData> StimData
		{
			get
			{
				if (_stimData == null)
				{
					_stimData = (CHandle<senseStimuliData>) CR2WTypeManager.Create("handle:senseStimuliData", "stimData", cr2w, this);
				}
				return _stimData;
			}
			set
			{
				if (_stimData == value)
				{
					return;
				}
				_stimData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stimInvestigateData")] 
		public stimInvestigateData StimInvestigateData
		{
			get
			{
				if (_stimInvestigateData == null)
				{
					_stimInvestigateData = (stimInvestigateData) CR2WTypeManager.Create("stimInvestigateData", "stimInvestigateData", cr2w, this);
				}
				return _stimInvestigateData;
			}
			set
			{
				if (_stimInvestigateData == value)
				{
					return;
				}
				_stimInvestigateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stimEventData")] 
		public StimEventData StimEventData
		{
			get
			{
				if (_stimEventData == null)
				{
					_stimEventData = (StimEventData) CR2WTypeManager.Create("StimEventData", "stimEventData", cr2w, this);
				}
				return _stimEventData;
			}
			set
			{
				if (_stimEventData == value)
				{
					return;
				}
				_stimEventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("initAnimInWorkspot")] 
		public CBool InitAnimInWorkspot
		{
			get
			{
				if (_initAnimInWorkspot == null)
				{
					_initAnimInWorkspot = (CBool) CR2WTypeManager.Create("Bool", "initAnimInWorkspot", cr2w, this);
				}
				return _initAnimInWorkspot;
			}
			set
			{
				if (_initAnimInWorkspot == value)
				{
					return;
				}
				_initAnimInWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("validTillTimeStamp")] 
		public CFloat ValidTillTimeStamp
		{
			get
			{
				if (_validTillTimeStamp == null)
				{
					_validTillTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "validTillTimeStamp", cr2w, this);
				}
				return _validTillTimeStamp;
			}
			set
			{
				if (_validTillTimeStamp == value)
				{
					return;
				}
				_validTillTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("recentReactionTimeStamp")] 
		public CFloat RecentReactionTimeStamp
		{
			get
			{
				if (_recentReactionTimeStamp == null)
				{
					_recentReactionTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "recentReactionTimeStamp", cr2w, this);
				}
				return _recentReactionTimeStamp;
			}
			set
			{
				if (_recentReactionTimeStamp == value)
				{
					return;
				}
				_recentReactionTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("escalateProvoke")] 
		public CBool EscalateProvoke
		{
			get
			{
				if (_escalateProvoke == null)
				{
					_escalateProvoke = (CBool) CR2WTypeManager.Create("Bool", "escalateProvoke", cr2w, this);
				}
				return _escalateProvoke;
			}
			set
			{
				if (_escalateProvoke == value)
				{
					return;
				}
				_escalateProvoke = value;
				PropertySet(this);
			}
		}

		public AIReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
