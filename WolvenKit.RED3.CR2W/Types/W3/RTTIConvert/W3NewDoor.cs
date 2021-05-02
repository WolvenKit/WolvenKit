using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NewDoor : W3LockableEntity
	{
		[Ordinal(1)] [RED("openAngle")] 		public CFloat OpenAngle { get; set;}

		[Ordinal(2)] [RED("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[Ordinal(3)] [RED("factOnPlayerDoorOpen")] 		public CName FactOnPlayerDoorOpen { get; set;}

		[Ordinal(4)] [RED("openedByHorse")] 		public CBool OpenedByHorse { get; set;}

		[Ordinal(5)] [RED("doorsCmp")] 		public CHandle<CDoorComponent> DoorsCmp { get; set;}

		[Ordinal(6)] [RED("lockedCmp")] 		public CHandle<CInteractionComponent> LockedCmp { get; set;}

		[Ordinal(7)] [RED("unlockCmp")] 		public CHandle<CInteractionComponent> UnlockCmp { get; set;}

		[Ordinal(8)] [RED("lockedDA")] 		public CHandle<CDeniedAreaComponent> LockedDA { get; set;}

		[Ordinal(9)] [RED("rigidMeshCmp")] 		public CHandle<CRigidMeshComponent> RigidMeshCmp { get; set;}

		[Ordinal(10)] [RED("updateDuration")] 		public CFloat UpdateDuration { get; set;}

		[Ordinal(11)] [RED("updateTimeLeft")] 		public CFloat UpdateTimeLeft { get; set;}

		[Ordinal(12)] [RED("playerInsideTrapdoorTrigger")] 		public CBool PlayerInsideTrapdoorTrigger { get; set;}

		[Ordinal(13)] [RED("enableDeniedAreaInCombat")] 		public CBool EnableDeniedAreaInCombat { get; set;}

		public W3NewDoor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NewDoor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}