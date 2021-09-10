using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterGradient : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("gradient")] 
		public CResourceReference<CGradient> Gradient
		{
			get => GetPropertyValue<CResourceReference<CGradient>>();
			set => SetPropertyValue<CResourceReference<CGradient>>(value);
		}
	}
}
