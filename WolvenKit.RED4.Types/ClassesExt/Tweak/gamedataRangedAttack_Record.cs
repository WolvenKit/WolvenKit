
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRangedAttack_Record
	{
		[RED("explosionAttack")]
		[REDProperty(IsIgnored = true)]
		public CName ExplosionAttack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("hitCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat HitCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("NPCAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NPCAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("NPCTimeDilated")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NPCTimeDilated
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playerAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playerTimeDilated")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerTimeDilated
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
