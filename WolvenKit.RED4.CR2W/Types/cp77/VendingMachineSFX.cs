using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineSFX : CVariable
	{
		private CName _glitchingStart;
		private CName _glitchingStop;

		[Ordinal(0)] 
		[RED("glitchingStart")] 
		public CName GlitchingStart
		{
			get => GetProperty(ref _glitchingStart);
			set => SetProperty(ref _glitchingStart, value);
		}

		[Ordinal(1)] 
		[RED("glitchingStop")] 
		public CName GlitchingStop
		{
			get => GetProperty(ref _glitchingStop);
			set => SetProperty(ref _glitchingStop, value);
		}

		public VendingMachineSFX(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
