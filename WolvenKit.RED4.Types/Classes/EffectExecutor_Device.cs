using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("maxDelay")] 
		public CFloat MaxDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
