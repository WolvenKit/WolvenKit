
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAddStatusEffectToAttackEffector_Record
	{
		[RED("applicationChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ApplicationChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isRandom")]
		[REDProperty(IsIgnored = true)]
		public CBool IsRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stacks")]
		[REDProperty(IsIgnored = true)]
		public CFloat Stacks
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
