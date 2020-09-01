using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVehicleComponent : CComponent
	{
		[Ordinal(0)] [RED("user")] 		public CHandle<CActor> User { get; set;}

		[Ordinal(0)] [RED("isCameraActivated")] 		public CBool IsCameraActivated { get; set;}

		[Ordinal(0)] [RED("isPlayingSyncAnimation")] 		public CBool IsPlayingSyncAnimation { get; set;}

		[Ordinal(0)] [RED("slots", 2,0)] 		public CArray<Vector> Slots { get; set;}

		[Ordinal(0)] [RED("mainStateName")] 		public CName MainStateName { get; set;}

		[Ordinal(0)] [RED("passengerStateName")] 		public CName PassengerStateName { get; set;}

		[Ordinal(0)] [RED("userCombatManager")] 		public CHandle<W3VehicleCombatManager> UserCombatManager { get; set;}

		[Ordinal(0)] [RED("canBoardTheBoat")] 		public CBool CanBoardTheBoat { get; set;}

		[Ordinal(0)] [RED("commandToMountActorToMount")] 		public CHandle<CActor> CommandToMountActorToMount { get; set;}

		[Ordinal(0)] [RED("commandToMountMountType")] 		public CEnum<EMountType> CommandToMountMountType { get; set;}

		[Ordinal(0)] [RED("commandToMountVehicleSlot")] 		public CEnum<EVehicleSlot> CommandToMountVehicleSlot { get; set;}

		public CVehicleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVehicleComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}