using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class genLevelRandomizerEntry : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CString Id { get; set; }
		[Ordinal(1)]  [RED("probability")] public CFloat Probability { get; set; }
		[Ordinal(2)]  [RED("spawnPos")] public NodeRef SpawnPos { get; set; }
		[Ordinal(3)]  [RED("templateName")] public CName TemplateName { get; set; }

		public genLevelRandomizerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
