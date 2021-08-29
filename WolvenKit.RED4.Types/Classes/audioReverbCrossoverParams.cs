using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioReverbCrossoverParams : RedBaseClass
	{
		private CFloat _dist;
		private CFloat _fade;

		[Ordinal(0)] 
		[RED("dist")] 
		public CFloat Dist
		{
			get => GetProperty(ref _dist);
			set => SetProperty(ref _dist, value);
		}

		[Ordinal(1)] 
		[RED("fade")] 
		public CFloat Fade
		{
			get => GetProperty(ref _fade);
			set => SetProperty(ref _fade, value);
		}
	}
}
