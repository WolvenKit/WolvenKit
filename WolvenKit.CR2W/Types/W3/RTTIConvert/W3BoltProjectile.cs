using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BoltProjectile : W3ArrowProjectile
	{
		[Ordinal(1)] [RED("dismemberOnKill")] 		public CBool DismemberOnKill { get; set;}

		[Ordinal(2)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(3)] [RED("projectiles", 2,0)] 		public CArray<CHandle<W3BoltProjectile>> Projectiles { get; set;}

		[Ordinal(4)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(5)] [RED("crossbowId")] 		public SItemUniqueId CrossbowId { get; set;}

		[Ordinal(6)] [RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		[Ordinal(7)] [RED("hitVictims", 2,0)] 		public CArray<CHandle<CActor>> HitVictims { get; set;}

		[Ordinal(8)] [RED("wasShotUnderWater")] 		public CBool WasShotUnderWater { get; set;}

		[Ordinal(9)] [RED("visibility")] 		public CBool Visibility { get; set;}

		public W3BoltProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BoltProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}