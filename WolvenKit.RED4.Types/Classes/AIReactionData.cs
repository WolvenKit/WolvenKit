using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIReactionData : IScriptable
	{
		private CInt32 _reactionPriority;
		private CEnum<gamedataOutput> _reactionBehaviorName;
		private CFloat _reactionBehaviorAIPriority;
		private CFloat _reactionCooldown;
		private CWeakHandle<gameObject> _stimTarget;
		private Vector4 _stimSource;
		private CEnum<gamedataStimType> _stimType;
		private CEnum<gamedataStimPriority> _stimPriority;
		private CHandle<gamedataStim_Record> _stimRecord;
		private senseStimInvestigateData _stimInvestigateData;
		private StimEventData _stimEventData;
		private CBool _initAnimInWorkspot;
		private CFloat _validTillTimeStamp;
		private CFloat _recentReactionTimeStamp;
		private CBool _escalateProvoke;

		[Ordinal(0)] 
		[RED("reactionPriority")] 
		public CInt32 ReactionPriority
		{
			get => GetProperty(ref _reactionPriority);
			set => SetProperty(ref _reactionPriority, value);
		}

		[Ordinal(1)] 
		[RED("reactionBehaviorName")] 
		public CEnum<gamedataOutput> ReactionBehaviorName
		{
			get => GetProperty(ref _reactionBehaviorName);
			set => SetProperty(ref _reactionBehaviorName, value);
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorAIPriority")] 
		public CFloat ReactionBehaviorAIPriority
		{
			get => GetProperty(ref _reactionBehaviorAIPriority);
			set => SetProperty(ref _reactionBehaviorAIPriority, value);
		}

		[Ordinal(3)] 
		[RED("reactionCooldown")] 
		public CFloat ReactionCooldown
		{
			get => GetProperty(ref _reactionCooldown);
			set => SetProperty(ref _reactionCooldown, value);
		}

		[Ordinal(4)] 
		[RED("stimTarget")] 
		public CWeakHandle<gameObject> StimTarget
		{
			get => GetProperty(ref _stimTarget);
			set => SetProperty(ref _stimTarget, value);
		}

		[Ordinal(5)] 
		[RED("stimSource")] 
		public Vector4 StimSource
		{
			get => GetProperty(ref _stimSource);
			set => SetProperty(ref _stimSource, value);
		}

		[Ordinal(6)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(7)] 
		[RED("stimPriority")] 
		public CEnum<gamedataStimPriority> StimPriority
		{
			get => GetProperty(ref _stimPriority);
			set => SetProperty(ref _stimPriority, value);
		}

		[Ordinal(8)] 
		[RED("stimRecord")] 
		public CHandle<gamedataStim_Record> StimRecord
		{
			get => GetProperty(ref _stimRecord);
			set => SetProperty(ref _stimRecord, value);
		}

		[Ordinal(9)] 
		[RED("stimInvestigateData")] 
		public senseStimInvestigateData StimInvestigateData
		{
			get => GetProperty(ref _stimInvestigateData);
			set => SetProperty(ref _stimInvestigateData, value);
		}

		[Ordinal(10)] 
		[RED("stimEventData")] 
		public StimEventData StimEventData
		{
			get => GetProperty(ref _stimEventData);
			set => SetProperty(ref _stimEventData, value);
		}

		[Ordinal(11)] 
		[RED("initAnimInWorkspot")] 
		public CBool InitAnimInWorkspot
		{
			get => GetProperty(ref _initAnimInWorkspot);
			set => SetProperty(ref _initAnimInWorkspot, value);
		}

		[Ordinal(12)] 
		[RED("validTillTimeStamp")] 
		public CFloat ValidTillTimeStamp
		{
			get => GetProperty(ref _validTillTimeStamp);
			set => SetProperty(ref _validTillTimeStamp, value);
		}

		[Ordinal(13)] 
		[RED("recentReactionTimeStamp")] 
		public CFloat RecentReactionTimeStamp
		{
			get => GetProperty(ref _recentReactionTimeStamp);
			set => SetProperty(ref _recentReactionTimeStamp, value);
		}

		[Ordinal(14)] 
		[RED("escalateProvoke")] 
		public CBool EscalateProvoke
		{
			get => GetProperty(ref _escalateProvoke);
			set => SetProperty(ref _escalateProvoke, value);
		}
	}
}
