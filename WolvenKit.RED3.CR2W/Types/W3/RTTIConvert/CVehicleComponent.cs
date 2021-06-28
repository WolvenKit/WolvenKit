using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVehicleComponent : CComponent
	{
		[Ordinal(1)] [RED("user")] 		public CHandle<CActor> User { get; set;}

		[Ordinal(2)] [RED("isCameraActivated")] 		public CBool IsCameraActivated { get; set;}

		[Ordinal(3)] [RED("isPlayingSyncAnimation")] 		public CBool IsPlayingSyncAnimation { get; set;}

		[Ordinal(4)] [RED("slots", 2,0)] 		public CArray<Vector> Slots { get; set;}

		[Ordinal(5)] [RED("mainStateName")] 		public CName MainStateName { get; set;}

		[Ordinal(6)] [RED("passengerStateName")] 		public CName PassengerStateName { get; set;}

		[Ordinal(7)] [RED("userCombatManager")] 		public CHandle<W3VehicleCombatManager> UserCombatManager { get; set;}

		[Ordinal(8)] [RED("canBoardTheBoat")] 		public CBool CanBoardTheBoat { get; set;}

		[Ordinal(9)] [RED("commandToMountActorToMount")] 		public CHandle<CActor> CommandToMountActorToMount { get; set;}

		[Ordinal(10)] [RED("commandToMountMountType")] 		public CEnum<EMountType> CommandToMountMountType { get; set;}

		[Ordinal(11)] [RED("commandToMountVehicleSlot")] 		public CEnum<EVehicleSlot> CommandToMountVehicleSlot { get; set;}

		public CVehicleComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}