using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BreachViewTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)] [RED("myOwner")] public wCHandle<gameObject> MyOwner { get; set; }

		public BreachViewTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
