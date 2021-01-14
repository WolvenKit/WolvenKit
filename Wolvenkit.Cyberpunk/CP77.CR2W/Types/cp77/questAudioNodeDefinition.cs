using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("type")] public CHandle<questIAudioNodeType> Type { get; set; }

		public questAudioNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
