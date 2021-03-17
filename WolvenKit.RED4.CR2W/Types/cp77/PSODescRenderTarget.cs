using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTarget : CVariable
	{
		private CBool _blendEnable;
		private CEnum<PSODescBlendModeWriteMask> _writeMask;
		private CEnum<PSODescBlendModeOp> _colorOp;
		private CEnum<PSODescBlendModeOp> _alphaOp;
		private CEnum<PSODescBlendModeFactor> _destFactor;
		private CEnum<PSODescBlendModeFactor> _destAlphaFactor;
		private CEnum<PSODescBlendModeFactor> _srcFactor;
		private CEnum<PSODescBlendModeFactor> _srcAlphaFactor;

		[Ordinal(0)] 
		[RED("blendEnable")] 
		public CBool BlendEnable
		{
			get => GetProperty(ref _blendEnable);
			set => SetProperty(ref _blendEnable, value);
		}

		[Ordinal(1)] 
		[RED("writeMask")] 
		public CEnum<PSODescBlendModeWriteMask> WriteMask
		{
			get => GetProperty(ref _writeMask);
			set => SetProperty(ref _writeMask, value);
		}

		[Ordinal(2)] 
		[RED("colorOp")] 
		public CEnum<PSODescBlendModeOp> ColorOp
		{
			get => GetProperty(ref _colorOp);
			set => SetProperty(ref _colorOp, value);
		}

		[Ordinal(3)] 
		[RED("alphaOp")] 
		public CEnum<PSODescBlendModeOp> AlphaOp
		{
			get => GetProperty(ref _alphaOp);
			set => SetProperty(ref _alphaOp, value);
		}

		[Ordinal(4)] 
		[RED("destFactor")] 
		public CEnum<PSODescBlendModeFactor> DestFactor
		{
			get => GetProperty(ref _destFactor);
			set => SetProperty(ref _destFactor, value);
		}

		[Ordinal(5)] 
		[RED("destAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> DestAlphaFactor
		{
			get => GetProperty(ref _destAlphaFactor);
			set => SetProperty(ref _destAlphaFactor, value);
		}

		[Ordinal(6)] 
		[RED("srcFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcFactor
		{
			get => GetProperty(ref _srcFactor);
			set => SetProperty(ref _srcFactor, value);
		}

		[Ordinal(7)] 
		[RED("srcAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcAlphaFactor
		{
			get => GetProperty(ref _srcAlphaFactor);
			set => SetProperty(ref _srcAlphaFactor, value);
		}

		public PSODescRenderTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
