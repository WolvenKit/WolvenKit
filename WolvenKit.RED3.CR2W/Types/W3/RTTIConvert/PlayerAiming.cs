using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PlayerAiming : CObject
	{
		[Ordinal(1)] [RED("owner")] 		public CHandle<CR4Player> Owner { get; set;}

		[Ordinal(2)] [RED("throwable")] 		public CHandle<CThrowable> Throwable { get; set;}

		[Ordinal(3)] [RED("aimType")] 		public CEnum<EAimType> AimType { get; set;}

		[Ordinal(4)] [RED("throwPos")] 		public Vector ThrowPos { get; set;}

		[Ordinal(5)] [RED("sweptFriendly")] 		public CHandle<CEntity> SweptFriendly { get; set;}

		[Ordinal(6)] [RED("sweptActors", 2,0)] 		public CArray<CHandle<CActor>> SweptActors { get; set;}

		[Ordinal(7)] [RED("tracePosFrom")] 		public Vector TracePosFrom { get; set;}

		[Ordinal(8)] [RED("thrownBombImpactRadius")] 		public CFloat ThrownBombImpactRadius { get; set;}

		[Ordinal(9)] [RED("aimedTarget")] 		public CHandle<CActor> AimedTarget { get; set;}

		[Ordinal(10)] [RED("collisionGroupsNames", 2,0)] 		public CArray<CName> CollisionGroupsNames { get; set;}

		public PlayerAiming(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}