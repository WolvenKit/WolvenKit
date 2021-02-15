using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(1)] [RED("pingData")] public CHandle<PingCachedData> PingData { get; set; }

		public StopPingingNetworkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
