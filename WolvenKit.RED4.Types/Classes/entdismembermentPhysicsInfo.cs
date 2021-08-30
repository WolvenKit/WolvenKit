using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentPhysicsInfo : RedBaseClass
	{
		private CFloat _densityScale;

		[Ordinal(0)] 
		[RED("DensityScale")] 
		public CFloat DensityScale
		{
			get => GetProperty(ref _densityScale);
			set => SetProperty(ref _densityScale, value);
		}

		public entdismembermentPhysicsInfo()
		{
			_densityScale = 1.000000F;
		}
	}
}
