using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("AOEAreaSetup")] public AOEAreaSetup AOEAreaSetup { get; set; }

		public AOEAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
