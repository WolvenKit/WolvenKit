using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescBlendModeDesc : CVariable
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

		public PSODescBlendModeDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
