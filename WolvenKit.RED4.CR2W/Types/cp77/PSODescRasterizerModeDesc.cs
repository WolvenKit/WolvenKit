using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRasterizerModeDesc : CVariable
	{
		private CBool _wireframe;
		private CEnum<PSODescRasterizerModeFrontFaceWinding> _frontWinding;
		private CEnum<PSODescRasterizerModeCullMode> _cullMode;
		private CBool _allowMSAA;
		private CBool _conservativeRasterization;
		private CEnum<PSODescRasterizerModeOffsetMode> _offsetMode;
		private CBool _scissors;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("wireframe")] 
		public CBool Wireframe
		{
			get => GetProperty(ref _wireframe);
			set => SetProperty(ref _wireframe, value);
		}

		[Ordinal(1)] 
		[RED("frontWinding")] 
		public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding
		{
			get => GetProperty(ref _frontWinding);
			set => SetProperty(ref _frontWinding, value);
		}

		[Ordinal(2)] 
		[RED("cullMode")] 
		public CEnum<PSODescRasterizerModeCullMode> CullMode
		{
			get => GetProperty(ref _cullMode);
			set => SetProperty(ref _cullMode, value);
		}

		[Ordinal(3)] 
		[RED("allowMSAA")] 
		public CBool AllowMSAA
		{
			get => GetProperty(ref _allowMSAA);
			set => SetProperty(ref _allowMSAA, value);
		}

		[Ordinal(4)] 
		[RED("conservativeRasterization")] 
		public CBool ConservativeRasterization
		{
			get => GetProperty(ref _conservativeRasterization);
			set => SetProperty(ref _conservativeRasterization, value);
		}

		[Ordinal(5)] 
		[RED("offsetMode")] 
		public CEnum<PSODescRasterizerModeOffsetMode> OffsetMode
		{
			get => GetProperty(ref _offsetMode);
			set => SetProperty(ref _offsetMode, value);
		}

		[Ordinal(6)] 
		[RED("scissors")] 
		public CBool Scissors
		{
			get => GetProperty(ref _scissors);
			set => SetProperty(ref _scissors, value);
		}

		[Ordinal(7)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}

		public PSODescRasterizerModeDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
