using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinEntry : CVariable
	{
		[Ordinal(0)] [RED("id")] public gameNewMappinID Id { get; set; }
		[Ordinal(1)] [RED("type")] public CName Type { get; set; }
		[Ordinal(2)] [RED("worldPosition")] public Vector4 WorldPosition { get; set; }

		public gamemappinsMappinEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
