using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNPCNotInFrontOfPLayer : IBehTreeTask
	{
		[Ordinal(1)] [RED("coneAngle")] 		public CFloat ConeAngle { get; set;}

		[Ordinal(2)] [RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[Ordinal(3)] [RED("coneRange")] 		public CFloat ConeRange { get; set;}

		[Ordinal(4)] [RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[Ordinal(5)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(6)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(7)] [RED("testedAngle")] 		public CFloat TestedAngle { get; set;}

		public CBTTaskNPCNotInFrontOfPLayer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNPCNotInFrontOfPLayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}