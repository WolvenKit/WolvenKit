using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
