using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntry : CVariable
	{
		[Ordinal(0)]  [RED("keycard")] public TweakDBID Keycard { get; set; }
		[Ordinal(1)]  [RED("password")] public CName Password { get; set; }

		public SecurityAccessLevelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
