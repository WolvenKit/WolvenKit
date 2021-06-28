using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterial : CVariable
	{
		private CName _loopStart;
		private CName _loopEnd;

		[Ordinal(0)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get => GetProperty(ref _loopStart);
			set => SetProperty(ref _loopStart, value);
		}

		[Ordinal(1)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get => GetProperty(ref _loopEnd);
			set => SetProperty(ref _loopEnd, value);
		}

		public audioAudioFoliageMaterial(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
