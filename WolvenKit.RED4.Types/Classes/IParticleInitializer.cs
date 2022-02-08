using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleInitializer : IParticleModule
	{
		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
