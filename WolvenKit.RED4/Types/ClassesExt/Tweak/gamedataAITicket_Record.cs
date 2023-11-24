
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAITicket_Record
	{
		[RED("activationCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ActivationCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("conditionSuccessDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat ConditionSuccessDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("deactivationCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> DeactivationCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("deactivationConditionCheckInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeactivationConditionCheckInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("difficulty")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Difficulty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("difficultyComparisonOp")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DifficultyComparisonOp
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxNumberOfTickets")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxNumberOfTickets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxTicketDesyncTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTicketDesyncTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minNumberOfTickets")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinNumberOfTickets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minTicketDesyncTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinTicketDesyncTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("percentageNumberOfTickets")]
		[REDProperty(IsIgnored = true)]
		public CFloat PercentageNumberOfTickets
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("releaseAll")]
		[REDProperty(IsIgnored = true)]
		public CBool ReleaseAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("revokeOnTimeout")]
		[REDProperty(IsIgnored = true)]
		public CBool RevokeOnTimeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("scaleNumberOfTicketsFromWorkspots")]
		[REDProperty(IsIgnored = true)]
		public CBool ScaleNumberOfTicketsFromWorkspots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startCooldownOnFailure")]
		[REDProperty(IsIgnored = true)]
		public CBool StartCooldownOnFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("syncTimeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat SyncTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("syncWithTickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SyncWithTickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("ticketType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TicketType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("timeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
