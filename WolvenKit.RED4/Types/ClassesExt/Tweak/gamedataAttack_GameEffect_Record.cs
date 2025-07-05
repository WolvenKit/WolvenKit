
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_GameEffect_Record
	{
		[RED("attackTag")]
		[REDProperty(IsIgnored = true)]
		public CName AttackTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("audioAttackIndex")]
		[REDProperty(IsIgnored = true)]
		public CFloat AudioAttackIndex
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("audioTag")]
		[REDProperty(IsIgnored = true)]
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectName")]
		[REDProperty(IsIgnored = true)]
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectTag")]
		[REDProperty(IsIgnored = true)]
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("explosionAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ExplosionAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
