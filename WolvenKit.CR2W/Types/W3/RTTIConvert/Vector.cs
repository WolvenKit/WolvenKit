using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Vector : CVariable
	{
		[RED("X")] 		public CFloat X { get; set;}

		[RED("Y")] 		public CFloat Y { get; set;}

		[RED("Z")] 		public CFloat Z { get; set;}

		[RED("W")] 		public CFloat W { get; set;}

		public Vector(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new Vector(cr2w);

	}
}