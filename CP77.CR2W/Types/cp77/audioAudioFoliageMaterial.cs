using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterial : CVariable
	{
		[Ordinal(0)]  [RED("loopEnd")] public CName LoopEnd { get; set; }
		[Ordinal(1)]  [RED("loopStart")] public CName LoopStart { get; set; }

		public audioAudioFoliageMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
