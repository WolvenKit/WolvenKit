using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TerminalSetup : CVariable
	{
		[Ordinal(0)]  [RED("ignoreSlaveAuthorizationModule")] public CBool IgnoreSlaveAuthorizationModule { get; set; }
		[Ordinal(1)]  [RED("maxClearance")] public CInt32 MaxClearance { get; set; }
		[Ordinal(2)]  [RED("minClearance")] public CInt32 MinClearance { get; set; }
		[Ordinal(3)]  [RED("shouldForceVirtualSystem")] public CBool ShouldForceVirtualSystem { get; set; }

		public TerminalSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
