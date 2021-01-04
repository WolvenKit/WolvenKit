using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)]  [RED("myOwner")] public wCHandle<sampleTimeDilatable> MyOwner { get; set; }

		public sampleTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
