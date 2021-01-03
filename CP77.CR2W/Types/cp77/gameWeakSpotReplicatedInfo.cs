using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameWeakSpotReplicatedInfo : CVariable
	{
		[Ordinal(0)]  [RED("LastDamageInstigator")] public wCHandle<gamePuppet> LastDamageInstigator { get; set; }
		[Ordinal(1)]  [RED("weakSpotRecordID")] public CUInt64 WeakSpotRecordID { get; set; }
		[Ordinal(2)]  [RED("wsHealthValue")] public CFloat WsHealthValue { get; set; }

		public gameWeakSpotReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
