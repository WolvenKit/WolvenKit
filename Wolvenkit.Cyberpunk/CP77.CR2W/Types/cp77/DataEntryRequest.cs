using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataEntryRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("data")] public CVariant Data { get; set; }
		[Ordinal(1)]  [RED("dataType")] public CEnum<EGameSessionDataType> DataType { get; set; }

		public DataEntryRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
