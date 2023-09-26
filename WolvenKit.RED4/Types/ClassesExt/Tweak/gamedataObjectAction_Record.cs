
namespace WolvenKit.RED4.Types
{
	public partial class gamedataObjectAction_Record
	{
		[RED("actionName")]
		[REDProperty(IsIgnored = true)]
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("activationTime")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ActivationTime
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("completionEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CompletionEffects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Cooldown
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("costs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Costs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("deviceHackCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DeviceHackCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("durationTime")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> DurationTime
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("gameplayCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID GameplayCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hackCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID HackCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hackTier")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID HackTier
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("instigatorActivePrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> InstigatorActivePrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("instigatorPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> InstigatorPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("interactionLayer")]
		[REDProperty(IsIgnored = true)]
		public CName InteractionLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("objectActionType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ObjectActionType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("objectActionUI")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ObjectActionUI
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rewards")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Rewards
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartEffects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("targetActivePrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TargetActivePrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("targetPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TargetPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
