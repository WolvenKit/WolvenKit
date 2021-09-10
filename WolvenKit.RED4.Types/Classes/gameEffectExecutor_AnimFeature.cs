using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature> AnimFeature
		{
			get => GetPropertyValue<CHandle<animAnimFeature>>();
			set => SetPropertyValue<CHandle<animAnimFeature>>(value);
		}

		[Ordinal(3)] 
		[RED("applyTo")] 
		public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo
		{
			get => GetPropertyValue<CEnum<gameEffectExecutor_AnimFeatureApplyTo>>();
			set => SetPropertyValue<CEnum<gameEffectExecutor_AnimFeatureApplyTo>>(value);
		}
	}
}
