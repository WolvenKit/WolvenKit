using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)]  [RED("myOwner")] public wCHandle<sampleTimeDilatable> MyOwner { get; set; }

		public sampleTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
