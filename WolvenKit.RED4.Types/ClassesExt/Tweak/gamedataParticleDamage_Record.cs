
namespace WolvenKit.RED4.Types
{
	public partial class gamedataParticleDamage_Record
	{
		[RED("attack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("particlePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ParticlePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
