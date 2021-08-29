using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSODescBlendModeDesc : RedBaseClass
	{
		private CUInt8 _numTargets;
		private CBool _independent;
		private CBool _alphaToCoverage;
		private CArrayFixedSize<PSODescRenderTarget> _renderTarget;

		[Ordinal(0)] 
		[RED("numTargets")] 
		public CUInt8 NumTargets
		{
			get => GetProperty(ref _numTargets);
			set => SetProperty(ref _numTargets, value);
		}

		[Ordinal(1)] 
		[RED("independent")] 
		public CBool Independent
		{
			get => GetProperty(ref _independent);
			set => SetProperty(ref _independent, value);
		}

		[Ordinal(2)] 
		[RED("alphaToCoverage")] 
		public CBool AlphaToCoverage
		{
			get => GetProperty(ref _alphaToCoverage);
			set => SetProperty(ref _alphaToCoverage, value);
		}

		[Ordinal(3)] 
		[RED("renderTarget", 8)] 
		public CArrayFixedSize<PSODescRenderTarget> RenderTarget
		{
			get => GetProperty(ref _renderTarget);
			set => SetProperty(ref _renderTarget, value);
		}
	}
}
