using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PlayerAiming : CObject
	{
		[RED("owner")] 		public CHandle<CR4Player> Owner { get; set;}

		[RED("throwable")] 		public CHandle<CThrowable> Throwable { get; set;}

		[RED("aimType")] 		public CEnum<EAimType> AimType { get; set;}

		[RED("throwPos")] 		public Vector ThrowPos { get; set;}

		[RED("sweptFriendly")] 		public CHandle<CEntity> SweptFriendly { get; set;}

		[RED("sweptActors", 2,0)] 		public CArray<CHandle<CActor>> SweptActors { get; set;}

		[RED("tracePosFrom")] 		public Vector TracePosFrom { get; set;}

		[RED("thrownBombImpactRadius")] 		public CFloat ThrownBombImpactRadius { get; set;}

		[RED("aimedTarget")] 		public CHandle<CActor> AimedTarget { get; set;}

		[RED("collisionGroupsNames", 2,0)] 		public CArray<CName> CollisionGroupsNames { get; set;}

		public PlayerAiming(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PlayerAiming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}