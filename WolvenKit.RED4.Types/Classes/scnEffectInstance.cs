using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnEffectInstance : RedBaseClass
	{
		private scnEffectInstanceId _effectInstanceId;
		private worldCompiledEffectInfo _compiledEffect;

		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get => GetProperty(ref _effectInstanceId);
			set => SetProperty(ref _effectInstanceId, value);
		}

		[Ordinal(1)] 
		[RED("compiledEffect")] 
		public worldCompiledEffectInfo CompiledEffect
		{
			get => GetProperty(ref _compiledEffect);
			set => SetProperty(ref _compiledEffect, value);
		}
	}
}
