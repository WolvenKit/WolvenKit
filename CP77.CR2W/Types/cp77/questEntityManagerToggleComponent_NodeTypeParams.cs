using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerToggleComponent_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questEntityManagerToggleComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
