using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Vector3 : CVariable
	{
		[Ordinal(1)] [RED("X")] 		public CFloat X { get; set;}

		[Ordinal(2)] [RED("Y")] 		public CFloat Y { get; set;}

		[Ordinal(3)] [RED("Z")] 		public CFloat Z { get; set;}

		public Vector3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Vector3(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}