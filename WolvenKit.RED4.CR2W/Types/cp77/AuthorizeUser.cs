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
			get
			{
				if (_enteredPassword == null)
				{
					_enteredPassword = (CName) CR2WTypeManager.Create("CName", "enteredPassword", cr2w, this);
				}
				return _enteredPassword;
			}
			set
			{
				if (_enteredPassword == value)
				{
					return;
				}
				_enteredPassword = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("validPasswords")] 
		public CArray<CName> ValidPasswords
		{
			get
			{
				if (_validPasswords == null)
				{
					_validPasswords = (CArray<CName>) CR2WTypeManager.Create("array:CName", "validPasswords", cr2w, this);
				}
				return _validPasswords;
			}
			set
			{
				if (_validPasswords == value)
				{
					return;
				}
				_validPasswords = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get
			{
				if (_libraryName == null)
				{
					_libraryName = (CName) CR2WTypeManager.Create("CName", "libraryName", cr2w, this);
				}
				return _libraryName;
			}
			set
			{
				if (_libraryName == value)
				{
					return;
				}
				_libraryName = value;
				PropertySet(this);
			}
		}

		public AuthorizeUser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
