using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopRTTIResourceDumpInfo : CVariable
	{
		private CString _extension;
		private CString _deprecatedExtension;
		private CString _friendlyDescription;

		[Ordinal(0)] 
		[RED("extension")] 
		public CString Extension
		{
			get
			{
				if (_extension == null)
				{
					_extension = (CString) CR2WTypeManager.Create("String", "extension", cr2w, this);
				}
				return _extension;
			}
			set
			{
				if (_extension == value)
				{
					return;
				}
				_extension = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deprecatedExtension")] 
		public CString DeprecatedExtension
		{
			get
			{
				if (_deprecatedExtension == null)
				{
					_deprecatedExtension = (CString) CR2WTypeManager.Create("String", "deprecatedExtension", cr2w, this);
				}
				return _deprecatedExtension;
			}
			set
			{
				if (_deprecatedExtension == value)
				{
					return;
				}
				_deprecatedExtension = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("friendlyDescription")] 
		public CString FriendlyDescription
		{
			get
			{
				if (_friendlyDescription == null)
				{
					_friendlyDescription = (CString) CR2WTypeManager.Create("String", "friendlyDescription", cr2w, this);
				}
				return _friendlyDescription;
			}
			set
			{
				if (_friendlyDescription == value)
				{
					return;
				}
				_friendlyDescription = value;
				PropertySet(this);
			}
		}

		public interopRTTIResourceDumpInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
