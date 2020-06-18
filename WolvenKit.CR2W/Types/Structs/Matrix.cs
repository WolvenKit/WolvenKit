using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class CMatrix : CVariable
	{
		[RED("X")] 		public Vector X { get; set;}

		[RED("Y")] 		public Vector Y { get; set;}

		[RED("Z")] 		public Vector Z { get; set;}

		[RED("W")] 		public Vector W { get; set;}

		public CMatrix(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CMatrix(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}