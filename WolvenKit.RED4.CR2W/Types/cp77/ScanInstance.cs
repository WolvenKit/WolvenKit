using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanInstance : ModuleInstance
	{
		[Ordinal(6)] [RED("isScanningCluesBlocked")] public CBool IsScanningCluesBlocked { get; set; }

		public ScanInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
