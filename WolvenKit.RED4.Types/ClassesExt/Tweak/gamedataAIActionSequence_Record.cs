
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionSequence_Record
	{
		[RED("actions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Actions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("activateCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActivateCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("activationCondition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActivationCondition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("disableActionsLimit")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableActionsLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("failOnNodeActivationConditionFailure")]
		[REDProperty(IsIgnored = true)]
		public CBool FailOnNodeActivationConditionFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasMemory")]
		[REDProperty(IsIgnored = true)]
		public CBool HasMemory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isVirtual")]
		[REDProperty(IsIgnored = true)]
		public CBool IsVirtual
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("minLOD")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinLOD
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
