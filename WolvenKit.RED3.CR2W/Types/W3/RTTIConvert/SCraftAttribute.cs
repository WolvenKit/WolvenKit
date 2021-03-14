using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftAttribute : CVariable
	{
		[Ordinal(1)] [RED("attributeName")] 		public CName AttributeName { get; set;}

		[Ordinal(2)] [RED("valAdditive")] 		public CFloat ValAdditive { get; set;}

		[Ordinal(3)] [RED("valMultiplicative")] 		public CFloat ValMultiplicative { get; set;}

		[Ordinal(4)] [RED("displayPercMul")] 		public CBool DisplayPercMul { get; set;}

		[Ordinal(5)] [RED("displayPercAdd")] 		public CBool DisplayPercAdd { get; set;}

		public SCraftAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCraftAttribute(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}