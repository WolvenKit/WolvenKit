using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("mask")] 
		public CResourceReference<Multilayer_Mask> Mask
		{
			get => GetPropertyValue<CResourceReference<Multilayer_Mask>>();
			set => SetPropertyValue<CResourceReference<Multilayer_Mask>>(value);
		}
	}
}
