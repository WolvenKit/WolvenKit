using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakSpotReplicatedInfo : CVariable
	{
		[Ordinal(0)] [RED("weakSpotRecordID")] public CUInt64 WeakSpotRecordID { get; set; }
		[Ordinal(1)] [RED("wsHealthValue")] public CFloat WsHealthValue { get; set; }
		[Ordinal(2)] [RED("LastDamageInstigator")] public wCHandle<gamePuppet> LastDamageInstigator { get; set; }

		public gameWeakSpotReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
