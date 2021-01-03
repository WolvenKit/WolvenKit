using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGrunt : CVariable
	{
		[Ordinal(0)]  [RED("regularGrunt")] public CName RegularGrunt { get; set; }
		[Ordinal(1)]  [RED("stealthGrunt")] public CName StealthGrunt { get; set; }

		public audioContextualVoiceGrunt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
