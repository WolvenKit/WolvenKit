
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionAnimSlot_Record
	{
		[RED("loopSlide")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LoopSlide
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("recoverySlide")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RecoverySlide
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("resetRagdollOnStart")]
		[REDProperty(IsIgnored = true)]
		public CBool ResetRagdollOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startupSlide")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StartupSlide
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useDynamicObjectsCheck")]
		[REDProperty(IsIgnored = true)]
		public CBool UseDynamicObjectsCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("usePoseMatching")]
		[REDProperty(IsIgnored = true)]
		public CBool UsePoseMatching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useRootMotion")]
		[REDProperty(IsIgnored = true)]
		public CBool UseRootMotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
