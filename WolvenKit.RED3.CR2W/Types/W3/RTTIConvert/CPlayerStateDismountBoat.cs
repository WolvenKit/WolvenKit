using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayerStateDismountBoat : CPlayerStateDismountTheVehicle
	{
		[Ordinal(1)] [RED("boatComp")] 		public CHandle<CBoatComponent> BoatComp { get; set;}

		[Ordinal(2)] [RED("remainingSlideDuration")] 		public CFloat RemainingSlideDuration { get; set;}

		[Ordinal(3)] [RED("fromPassenger")] 		public CBool FromPassenger { get; set;}

		public CPlayerStateDismountBoat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}