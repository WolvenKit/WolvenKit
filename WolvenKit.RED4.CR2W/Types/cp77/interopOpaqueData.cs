using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopOpaqueData : CVariable
	{
		private CString _description;
		private CString _payload;
		private CInt32 _version;

		[Ordinal(0)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("payload")] 
		public CString Payload
		{
			get
			{
				if (_payload == null)
				{
					_payload = (CString) CR2WTypeManager.Create("String", "payload", cr2w, this);
				}
				return _payload;
			}
			set
			{
				if (_payload == value)
				{
					return;
				}
				_payload = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("version")] 
		public CInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CInt32) CR2WTypeManager.Create("Int32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public interopOpaqueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
