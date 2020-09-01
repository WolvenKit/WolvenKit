using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateMountTheVehicle : CPlayerStateBase
	{
		[Ordinal(1)] [RED("vehicle")] 		public CHandle<CVehicleComponent> Vehicle { get; set;}

		[Ordinal(2)] [RED("mountType")] 		public CEnum<EMountType> MountType { get; set;}

		[Ordinal(3)] [RED("vehicleSlot")] 		public CEnum<EVehicleSlot> VehicleSlot { get; set;}

		[Ordinal(4)] [RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		public CR4PlayerStateMountTheVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateMountTheVehicle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}