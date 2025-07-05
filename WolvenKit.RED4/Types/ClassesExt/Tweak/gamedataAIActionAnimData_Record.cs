
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionAnimData_Record
	{
		[RED("animFeature")]
		[REDProperty(IsIgnored = true)]
		public CName AnimFeature
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("animSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AnimSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("animVariation")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AnimVariation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("animVariationSubAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AnimVariationSubAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("direction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Direction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("marginToPlayer")]
		[REDProperty(IsIgnored = true)]
		public CFloat MarginToPlayer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ragdollOnDeath")]
		[REDProperty(IsIgnored = true)]
		public CBool RagdollOnDeath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("updateMovePolicy")]
		[REDProperty(IsIgnored = true)]
		public CBool UpdateMovePolicy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("weaponOverride")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WeaponOverride
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
