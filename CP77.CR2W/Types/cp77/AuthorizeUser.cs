using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AuthorizeUser : ActionBool
	{
		[Ordinal(0)]  [RED("enteredPassword")] public CName EnteredPassword { get; set; }
		[Ordinal(1)]  [RED("libraryName")] public CName LibraryName { get; set; }
		[Ordinal(2)]  [RED("validPasswords")] public CArray<CName> ValidPasswords { get; set; }

		public AuthorizeUser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
