using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHorseRiderSharedParams : IScriptable
	{
		[Ordinal(0)] [RED("("rider")] 		public CHandle<CActor> Rider { get; set;}

		[Ordinal(0)] [RED("("horse")] 		public CHandle<CActor> Horse { get; set;}

		[Ordinal(0)] [RED("("mountStatus")] 		public CEnum<EVehicleMountStatus> MountStatus { get; set;}

		[Ordinal(0)] [RED("("boat")] 		public EntityHandle Boat { get; set;}

		[Ordinal(0)] [RED("("vehicleSlot")] 		public CEnum<EVehicleSlot> VehicleSlot { get; set;}

		[Ordinal(0)] [RED("("hasFallenFromHorse")] 		public CBool HasFallenFromHorse { get; set;}

		[Ordinal(0)] [RED("("scriptedActionPending")] 		public CBool ScriptedActionPending { get; set;}

		[Ordinal(0)] [RED("("isPlayingAnimWithRider")] 		public CBool IsPlayingAnimWithRider { get; set;}

		[Ordinal(0)] [RED("("combatTarget")] 		public CHandle<CActor> CombatTarget { get; set;}

		public CHorseRiderSharedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseRiderSharedParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}