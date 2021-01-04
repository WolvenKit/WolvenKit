using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeParameter : CVariable
	{
		[Ordinal(0)]  [RED("parameterId")] public CUInt16 ParameterId { get; set; }
		[Ordinal(1)]  [RED("parameterName")] public CName ParameterName { get; set; }
		[Ordinal(2)]  [RED("parameterType")] public CEnum<LibTreeEParameterType> ParameterType { get; set; }
		[Ordinal(3)]  [RED("value")] public CVariant Value { get; set; }

		public LibTreeParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
