using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateMountTheVehicle : CPlayerStateBase
	{
		[Ordinal(1)] [RED("vehicle")] 		public CHandle<CVehicleComponent> Vehicle { get; set;}

		[Ordinal(2)] [RED("mountType")] 		public CEnum<EMountType> MountType { get; set;}

		[Ordinal(3)] [RED("vehicleSlot")] 		public CEnum<EVehicleSlot> VehicleSlot { get; set;}

		[Ordinal(4)] [RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		public CR4PlayerStateMountTheVehicle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}