using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SubCharacterSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("uniqueSubCharacters")] public CArray<SSubCharacter> UniqueSubCharacters { get; set; }
		[Ordinal(1)]  [RED("scriptSpawnedFlathead")] public CBool ScriptSpawnedFlathead { get; set; }
		[Ordinal(2)]  [RED("isDespawningFlathead")] public CBool IsDespawningFlathead { get; set; }

		public SubCharacterSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
