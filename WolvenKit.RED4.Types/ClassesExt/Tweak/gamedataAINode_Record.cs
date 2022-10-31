
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINode_Record
	{
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
