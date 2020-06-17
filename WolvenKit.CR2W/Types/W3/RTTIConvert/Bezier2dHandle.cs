using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Bezier2dHandle : CVariable
	{
		[RED("incomingTangent")] 		public Vector2 IncomingTangent { get; set;}

		[RED("outgoingTangent")] 		public Vector2 OutgoingTangent { get; set;}

		public Bezier2dHandle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new Bezier2dHandle(cr2w);

	}
}