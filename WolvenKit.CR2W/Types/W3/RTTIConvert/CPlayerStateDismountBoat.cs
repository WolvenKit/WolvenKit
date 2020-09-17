using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlayerStateDismountBoat : CPlayerStateDismountTheVehicle
	{
		[Ordinal(1)] [RED("boatComp")] 		public CHandle<CBoatComponent> BoatComp { get; set;}

		[Ordinal(2)] [RED("remainingSlideDuration")] 		public CFloat RemainingSlideDuration { get; set;}

		[Ordinal(3)] [RED("fromPassenger")] 		public CBool FromPassenger { get; set;}

		public CPlayerStateDismountBoat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlayerStateDismountBoat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}