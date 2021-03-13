using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWorkspotData : CVariable
	{
		[Ordinal(0)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)] [RED("freeCamera")] public CBool FreeCamera { get; set; }
		[Ordinal(2)] [RED("operationType")] public CEnum<EWorkspotOperationType> OperationType { get; set; }

		public SWorkspotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
