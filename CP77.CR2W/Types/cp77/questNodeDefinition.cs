using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questNodeDefinition : graphGraphNodeDefinition
	{
		[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }

		public questNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
