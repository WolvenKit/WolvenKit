using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEffectDesc : ISerializable
	{
		[Ordinal(0)] [RED("id")] public CRUID Id { get; set; }
		[Ordinal(1)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(2)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(3)] [RED("compiledEffectInfo")] public worldCompiledEffectInfo CompiledEffectInfo { get; set; }
		[Ordinal(4)] [RED("autoSpawnTag")] public CName AutoSpawnTag { get; set; }
		[Ordinal(5)] [RED("isAutoSpawn")] public CBool IsAutoSpawn { get; set; }
		[Ordinal(6)] [RED("randomWeight")] public CUInt8 RandomWeight { get; set; }

		public entEffectDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
