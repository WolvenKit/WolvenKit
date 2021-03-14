using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("tresspasserList")] public CArray<TrespasserEntry> TresspasserList { get; set; }
		[Ordinal(104)] [RED("entranceToken")] public entEntityID EntranceToken { get; set; }
		[Ordinal(105)] [RED("isLeaving")] public CBool IsLeaving { get; set; }
		[Ordinal(106)] [RED("isLocked")] public CBool IsLocked { get; set; }

		public SecurityGateLockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
