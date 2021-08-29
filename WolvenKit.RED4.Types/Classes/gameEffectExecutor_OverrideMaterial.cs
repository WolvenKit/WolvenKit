using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_OverrideMaterial : gameEffectExecutor
	{
		private CResourceReference<IMaterial> _material;

		[Ordinal(1)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}
	}
}
