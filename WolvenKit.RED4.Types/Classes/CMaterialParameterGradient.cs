using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterGradient : CMaterialParameter
	{
		private CResourceReference<CGradient> _gradient;

		[Ordinal(2)] 
		[RED("gradient")] 
		public CResourceReference<CGradient> Gradient
		{
			get => GetProperty(ref _gradient);
			set => SetProperty(ref _gradient, value);
		}
	}
}
