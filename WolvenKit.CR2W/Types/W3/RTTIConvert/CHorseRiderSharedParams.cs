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
		[RED("rider")] 		public CHandle<CActor> Rider { get; set;}

		[RED("horse")] 		public CHandle<CActor> Horse { get; set;}

		[RED("mountStatus")] 		public CEnum<EVehicleMountStatus> MountStatus { get; set;}

		[RED("boat")] 		public EntityHandle Boat { get; set;}

		[RED("vehicleSlot")] 		public CEnum<EVehicleSlot> VehicleSlot { get; set;}

		[RED("hasFallenFromHorse")] 		public CBool HasFallenFromHorse { get; set;}

		[RED("scriptedActionPending")] 		public CBool ScriptedActionPending { get; set;}

		[RED("isPlayingAnimWithRider")] 		public CBool IsPlayingAnimWithRider { get; set;}

		[RED("combatTarget")] 		public CHandle<CActor> CombatTarget { get; set;}

		public CHorseRiderSharedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseRiderSharedParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}