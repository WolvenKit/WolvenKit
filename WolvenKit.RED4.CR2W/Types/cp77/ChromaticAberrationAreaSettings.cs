using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChromaticAberrationAreaSettings : IAreaSettings
	{
		private CBool _chromaticAberrationEnabled;
		private CFloat _chromaticAberrationMargin;
		private CFloat _chromaticAberrationOffset;
		private CFloat _chromaticAberrationExp;
		private CFloat _subpixelDispersal;

		[Ordinal(2)] 
		[RED("chromaticAberrationEnabled")] 
		public CBool ChromaticAberrationEnabled
		{
			get => GetProperty(ref _chromaticAberrationEnabled);
			set => SetProperty(ref _chromaticAberrationEnabled, value);
		}

		[Ordinal(3)] 
		[RED("chromaticAberrationMargin")] 
		public CFloat ChromaticAberrationMargin
		{
			get => GetProperty(ref _chromaticAberrationMargin);
			set => SetProperty(ref _chromaticAberrationMargin, value);
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationOffset")] 
		public CFloat ChromaticAberrationOffset
		{
			get => GetProperty(ref _chromaticAberrationOffset);
			set => SetProperty(ref _chromaticAberrationOffset, value);
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public CFloat ChromaticAberrationExp
		{
			get => GetProperty(ref _chromaticAberrationExp);
			set => SetProperty(ref _chromaticAberrationExp, value);
		}

		[Ordinal(6)] 
		[RED("subpixelDispersal")] 
		public CFloat SubpixelDispersal
		{
			get => GetProperty(ref _subpixelDispersal);
			set => SetProperty(ref _subpixelDispersal, value);
		}

		public ChromaticAberrationAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
