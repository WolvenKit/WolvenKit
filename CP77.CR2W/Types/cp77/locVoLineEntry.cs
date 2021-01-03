using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class locVoLineEntry : CVariable
	{
		[Ordinal(0)]  [RED("femaleResPath")] public raRef<locVoResource> FemaleResPath { get; set; }
		[Ordinal(1)]  [RED("maleResPath")] public raRef<locVoResource> MaleResPath { get; set; }
		[Ordinal(2)]  [RED("stringId")] public CRUID StringId { get; set; }

		public locVoLineEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
