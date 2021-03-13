using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterial : CVariable
	{
		[Ordinal(0)] [RED("loopStart")] public CName LoopStart { get; set; }
		[Ordinal(1)] [RED("loopEnd")] public CName LoopEnd { get; set; }

		public audioAudioFoliageMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
