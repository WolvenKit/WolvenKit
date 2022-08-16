
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAction_Record
	{
		[RED("ability")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ability
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("allowBlendDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AllowBlendDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("allowBlendPercCap")]
		[REDProperty(IsIgnored = true)]
		public CFloat AllowBlendPercCap
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("animationWrapperOverrides")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AnimationWrapperOverrides
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("animData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AnimData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("commands")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Commands
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("completeWithFailure")]
		[REDProperty(IsIgnored = true)]
		public CBool CompleteWithFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("disableAction")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("failIfAnimationNotStreamedIn")]
		[REDProperty(IsIgnored = true)]
		public CBool FailIfAnimationNotStreamedIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("initCooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> InitCooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("lookats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Lookats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("loop")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Loop
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("loopEndCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LoopEndCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("loopRepeatCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LoopRepeatCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("loopSubActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LoopSubActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("recovery")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Recovery
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("recoveryEndCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RecoveryEndCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("recoveryRepeatCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RecoveryRepeatCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("recoverySubActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RecoverySubActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("revokingTicketCompletesAction")]
		[REDProperty(IsIgnored = true)]
		public CBool RevokingTicketCompletesAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Startup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("startupEndCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StartupEndCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("startupRepeatCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StartupRepeatCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("startupSubActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartupSubActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("subActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SubActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("subActionsCanCompleteAction")]
		[REDProperty(IsIgnored = true)]
		public CBool SubActionsCanCompleteAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ticketAcknowledgeTimeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat TicketAcknowledgeTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Tickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("waitForAnimationToLoad")]
		[REDProperty(IsIgnored = true)]
		public CBool WaitForAnimationToLoad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
