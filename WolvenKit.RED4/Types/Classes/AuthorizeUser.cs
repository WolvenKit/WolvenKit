using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AuthorizeUser : ActionBool
	{
		[Ordinal(38)] 
		[RED("enteredPassword")] 
		public CName EnteredPassword
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(39)] 
		[RED("validPasswords")] 
		public CArray<CName> ValidPasswords
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(40)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("isforced")] 
		public CBool Isforced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AuthorizeUser()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
