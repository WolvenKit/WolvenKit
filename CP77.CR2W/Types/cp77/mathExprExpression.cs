using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class mathExprExpression : ISerializable
	{
		[Ordinal(0)]  [RED("returnVarType")] public CUInt16 ReturnVarType { get; set; }
		[Ordinal(1)]  [RED("tokenData")] public CArray<CUInt32> TokenData { get; set; }
		[Ordinal(2)]  [RED("valuesData")] public CArray<CFloat> ValuesData { get; set; }

		public mathExprExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
