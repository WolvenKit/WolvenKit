using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIAlertedStateDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("attackInstigatorPosition")] public Vector4 AttackInstigatorPosition { get; set; }

		public AIAlertedStateDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
