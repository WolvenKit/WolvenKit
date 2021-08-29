using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		private CName _key;
		private CHandle<animAnimFeature> _animFeature;
		private CEnum<gameEffectExecutor_AnimFeatureApplyTo> _applyTo;

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(3)] 
		[RED("applyTo")] 
		public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo
		{
			get => GetProperty(ref _applyTo);
			set => SetProperty(ref _applyTo, value);
		}
	}
}
