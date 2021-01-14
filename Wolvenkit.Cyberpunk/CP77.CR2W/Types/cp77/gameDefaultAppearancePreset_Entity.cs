using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDefaultAppearancePreset_Entity : ISerializable
	{
		[Ordinal(0)]  [RED("debugEntityPath")] public CName DebugEntityPath { get; set; }
		[Ordinal(1)]  [RED("defaultAppearanceName")] public CName DefaultAppearanceName { get; set; }
		[Ordinal(2)]  [RED("entityPathHash")] public CUInt64 EntityPathHash { get; set; }

		public gameDefaultAppearancePreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
