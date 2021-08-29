using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		private CFloat _maxDelay;

		[Ordinal(1)] 
		[RED("maxDelay")] 
		public CFloat MaxDelay
		{
			get => GetProperty(ref _maxDelay);
			set => SetProperty(ref _maxDelay, value);
		}
	}
}
