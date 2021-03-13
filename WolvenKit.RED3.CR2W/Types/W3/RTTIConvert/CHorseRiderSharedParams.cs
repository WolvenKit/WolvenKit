using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHorseRiderSharedParams : IScriptable
	{
		[Ordinal(1)] [RED("rider")] 		public CHandle<CActor> Rider { get; set;}

		[Ordinal(2)] [RED("horse")] 		public CHandle<CActor> Horse { get; set;}

		[Ordinal(3)] [RED("mountStatus")] 		public CEnum<EVehicleMountStatus> MountStatus { get; set;}

		[Ordinal(4)] [RED("boat")] 		public EntityHandle Boat { get; set;}

		[Ordinal(5)] [RED("vehicleSlot")] 		public CEnum<EVehicleSlot> VehicleSlot { get; set;}

		[Ordinal(6)] [RED("hasFallenFromHorse")] 		public CBool HasFallenFromHorse { get; set;}

		[Ordinal(7)] [RED("scriptedActionPending")] 		public CBool ScriptedActionPending { get; set;}

		[Ordinal(8)] [RED("isPlayingAnimWithRider")] 		public CBool IsPlayingAnimWithRider { get; set;}

		[Ordinal(9)] [RED("combatTarget")] 		public CHandle<CActor> CombatTarget { get; set;}

		public CHorseRiderSharedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseRiderSharedParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}