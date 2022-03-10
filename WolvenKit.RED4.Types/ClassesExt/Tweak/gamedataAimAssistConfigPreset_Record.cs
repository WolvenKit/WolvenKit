
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistConfigPreset_Record
	{
		[RED("aimSnapParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AimSnapParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("bulletMagnetismParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BulletMagnetismParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("commonParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CommonParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("finishingParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FinishingParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("magnetismParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MagnetismParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("meleeParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MeleeParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
