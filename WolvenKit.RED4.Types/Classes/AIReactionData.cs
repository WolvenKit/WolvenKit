using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIReactionData : IScriptable
	{
		[Ordinal(0)] 
		[RED("reactionPriority")] 
		public CInt32 ReactionPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("reactionBehaviorName")] 
		public CEnum<gamedataOutput> ReactionBehaviorName
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorAIPriority")] 
		public CFloat ReactionBehaviorAIPriority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("reactionCooldown")] 
		public CFloat ReactionCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("stimTarget")] 
		public CWeakHandle<gameObject> StimTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("stimSource")] 
		public Vector4 StimSource
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(7)] 
		[RED("stimPriority")] 
		public CEnum<gamedataStimPriority> StimPriority
		{
			get => GetPropertyValue<CEnum<gamedataStimPriority>>();
			set => SetPropertyValue<CEnum<gamedataStimPriority>>(value);
		}

		[Ordinal(8)] 
		[RED("stimRecord")] 
		public CHandle<gamedataStim_Record> StimRecord
		{
			get => GetPropertyValue<CHandle<gamedataStim_Record>>();
			set => SetPropertyValue<CHandle<gamedataStim_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("stimInvestigateData")] 
		public senseStimInvestigateData StimInvestigateData
		{
			get => GetPropertyValue<senseStimInvestigateData>();
			set => SetPropertyValue<senseStimInvestigateData>(value);
		}

		[Ordinal(10)] 
		[RED("stimEventData")] 
		public StimEventData StimEventData
		{
			get => GetPropertyValue<StimEventData>();
			set => SetPropertyValue<StimEventData>(value);
		}

		[Ordinal(11)] 
		[RED("initAnimInWorkspot")] 
		public CBool InitAnimInWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("skipInitialAnimation")] 
		public CBool SkipInitialAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("validTillTimeStamp")] 
		public CFloat ValidTillTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("recentReactionTimeStamp")] 
		public CFloat RecentReactionTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("escalateProvoke")] 
		public CBool EscalateProvoke
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIReactionData()
		{
			StimSource = new();
			StimInvestigateData = new() { DistrationPoint = new(), AttackInstigatorPosition = new(), InvestigationSpots = new() };
			StimEventData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
