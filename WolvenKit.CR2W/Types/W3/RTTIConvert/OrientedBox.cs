using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class OrientedBox : CVariable
	{
		[RED("position")] 		public Vector Position { get; set;}

		[RED("edge 1")] 		public Vector Edge_1 { get; set;}

		[RED("edge 2")] 		public Vector Edge_2 { get; set;}

		public OrientedBox(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new OrientedBox(cr2w);

	}
}