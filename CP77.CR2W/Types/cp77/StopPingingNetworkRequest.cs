using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("pingData")] public CHandle<PingCachedData> PingData { get; set; }
		[Ordinal(1)]  [RED("source")] public wCHandle<gameObject> Source { get; set; }

		public StopPingingNetworkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
