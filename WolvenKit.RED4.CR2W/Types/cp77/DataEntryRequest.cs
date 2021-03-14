using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataEntryRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("dataType")] public CEnum<EGameSessionDataType> DataType { get; set; }
		[Ordinal(1)] [RED("data")] public CVariant Data { get; set; }

		public DataEntryRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
