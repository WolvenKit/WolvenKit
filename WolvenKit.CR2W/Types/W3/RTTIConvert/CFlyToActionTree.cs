using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyToActionTree : IFlightActionTree
	{
		[RED("acceptDistance")] 		public CFloat AcceptDistance { get; set;}

		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("rotateBeforeTakeOff")] 		public CBool RotateBeforeTakeOff { get; set;}

		[RED("landAtTargetLocation")] 		public CBool LandAtTargetLocation { get; set;}

		[RED("landingForwardOffset")] 		public CFloat LandingForwardOffset { get; set;}

		public CFlyToActionTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFlyToActionTree(cr2w);

	}
}