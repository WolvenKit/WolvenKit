using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameter : ISerializable
	{
        [Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
        [Ordinal(1)]  [RED("register")] public CUInt32 Register_ { get; set; }

		public CMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
