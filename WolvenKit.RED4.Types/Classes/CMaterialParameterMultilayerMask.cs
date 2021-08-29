using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		private CResourceReference<Multilayer_Mask> _mask;

		[Ordinal(2)] 
		[RED("mask")] 
		public CResourceReference<Multilayer_Mask> Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}
	}
}
