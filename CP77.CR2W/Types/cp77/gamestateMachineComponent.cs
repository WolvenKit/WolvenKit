using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponent : gamePlayerControlledComponent
	{
		[Ordinal(3)] [RED("packageName")] public CString PackageName { get; set; }

		public gamestateMachineComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
