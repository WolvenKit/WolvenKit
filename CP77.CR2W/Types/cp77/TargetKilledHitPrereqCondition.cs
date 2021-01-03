using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetKilledHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("lastTarget")] public wCHandle<gameObject> LastTarget { get; set; }

		public TargetKilledHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
