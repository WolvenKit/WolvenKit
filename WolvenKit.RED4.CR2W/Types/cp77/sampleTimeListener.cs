using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)] [RED("myOwner")] public wCHandle<sampleTimeDilatable> MyOwner { get; set; }

		public sampleTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
