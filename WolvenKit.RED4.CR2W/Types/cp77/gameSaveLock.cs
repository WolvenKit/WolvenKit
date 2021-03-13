using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSaveLock : CVariable
	{
		[Ordinal(0)] [RED("reason")] public CEnum<gameSaveLockReason> Reason { get; set; }

		public gameSaveLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
