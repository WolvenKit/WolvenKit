using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class mathExprExpression : ISerializable
	{
		[Ordinal(0)] [RED("tokenData")] public CArray<CUInt32> TokenData { get; set; }
		[Ordinal(1)] [RED("valuesData")] public CArray<CFloat> ValuesData { get; set; }
		[Ordinal(2)] [RED("returnVarType")] public CUInt16 ReturnVarType { get; set; }

		public mathExprExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
