using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyToActionTree : IFlightActionTree
	{
		[Ordinal(1)] [RED("acceptDistance")] 		public CFloat AcceptDistance { get; set;}

		[Ordinal(2)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(3)] [RED("rotateBeforeTakeOff")] 		public CBool RotateBeforeTakeOff { get; set;}

		[Ordinal(4)] [RED("landAtTargetLocation")] 		public CBool LandAtTargetLocation { get; set;}

		[Ordinal(5)] [RED("landingForwardOffset")] 		public CFloat LandingForwardOffset { get; set;}

		public CFlyToActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyToActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}