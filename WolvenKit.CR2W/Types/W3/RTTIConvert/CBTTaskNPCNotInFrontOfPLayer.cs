using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNPCNotInFrontOfPLayer : IBehTreeTask
	{
		[Ordinal(0)] [RED("coneAngle")] 		public CFloat ConeAngle { get; set;}

		[Ordinal(0)] [RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[Ordinal(0)] [RED("coneRange")] 		public CFloat ConeRange { get; set;}

		[Ordinal(0)] [RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[Ordinal(0)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(0)] [RED("testedAngle")] 		public CFloat TestedAngle { get; set;}

		public CBTTaskNPCNotInFrontOfPLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNPCNotInFrontOfPLayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}