using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_LayerTemplateOverridesColor : RedBaseClass
	{
		private CName _n;
		private CArrayFixedSize<CFloat> _v;

		[Ordinal(0)] 
		[RED("n")] 
		public CName N
		{
			get => GetProperty(ref _n);
			set => SetProperty(ref _n, value);
		}

		[Ordinal(1)] 
		[RED("v", 3)] 
		public CArrayFixedSize<CFloat> V
		{
			get => GetProperty(ref _v);
			set => SetProperty(ref _v, value);
		}
	}
}
