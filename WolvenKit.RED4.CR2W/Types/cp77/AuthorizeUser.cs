using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AuthorizeUser : ActionBool
	{
		private CName _enteredPassword;
		private CArray<CName> _validPasswords;
		private CName _libraryName;

		[Ordinal(25)] 
		[RED("enteredPassword")] 
		public CName EnteredPassword
		{
			get => GetProperty(ref _enteredPassword);
			set => SetProperty(ref _enteredPassword, value);
		}

		[Ordinal(26)] 
		[RED("validPasswords")] 
		public CArray<CName> ValidPasswords
		{
			get => GetProperty(ref _validPasswords);
			set => SetProperty(ref _validPasswords, value);
		}

		[Ordinal(27)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetProperty(ref _libraryName);
			set => SetProperty(ref _libraryName, value);
		}

		public AuthorizeUser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
