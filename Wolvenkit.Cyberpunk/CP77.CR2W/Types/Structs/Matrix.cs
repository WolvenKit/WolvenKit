using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class CMatrix : CVariable
	{
		[Ordinal(1)] [RED("X")] 		public Vector4 X { get; set;}

		[Ordinal(2)] [RED("Y")] 		public Vector4 Y { get; set;}

		[Ordinal(3)] [RED("Z")] 		public Vector4 Z { get; set;}

		[Ordinal(4)] [RED("W")] 		public Vector4 W { get; set;}

		public CMatrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }
    }
}