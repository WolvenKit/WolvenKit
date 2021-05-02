using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMonsterParam : CGameplayEntityParam
	{
		[Ordinal(1)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(2)] [RED("canBeTargeted")] 		public CBool CanBeTargeted { get; set;}

		[Ordinal(3)] [RED("canBeHitByFists")] 		public CBool CanBeHitByFists { get; set;}

		[Ordinal(4)] [RED("canBeStrafed")] 		public CBool CanBeStrafed { get; set;}

		[Ordinal(5)] [RED("monsterCategory")] 		public CInt32 MonsterCategory { get; set;}

		[Ordinal(6)] [RED("soundMonsterName")] 		public CName SoundMonsterName { get; set;}

		public CMonsterParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMonsterParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}