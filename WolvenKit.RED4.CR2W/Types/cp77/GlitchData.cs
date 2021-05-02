using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlitchData : CVariable
	{
		private CFloat _intensity;
		private CEnum<EGlitchState> _state;

		[Ordinal(0)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EGlitchState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public GlitchData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
