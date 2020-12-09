using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskElementalDaoStoneSmash : CBTTaskAttack
	{
		[Ordinal(1)] [RED("stoneEntityTemplate")] 		public CHandle<CEntityTemplate> StoneEntityTemplate { get; set;}

		[Ordinal(2)] [RED("Stone1")] 		public CHandle<CEntity> Stone1 { get; set;}

		[Ordinal(3)] [RED("Stone2")] 		public CHandle<CEntity> Stone2 { get; set;}

		[Ordinal(4)] [RED("execute")] 		public CBool Execute { get; set;}

		[Ordinal(5)] [RED("spawnDist")] 		public CFloat SpawnDist { get; set;}

		[Ordinal(6)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(7)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		public CBTTaskElementalDaoStoneSmash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskElementalDaoStoneSmash(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}