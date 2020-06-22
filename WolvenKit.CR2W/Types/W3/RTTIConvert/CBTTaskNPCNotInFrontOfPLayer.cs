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
		[RED("coneAngle")] 		public CFloat ConeAngle { get; set;}

		[RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[RED("coneRange")] 		public CFloat ConeRange { get; set;}

		[RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("testedAngle")] 		public CFloat TestedAngle { get; set;}

		public CBTTaskNPCNotInFrontOfPLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNPCNotInFrontOfPLayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}