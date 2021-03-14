using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkServerInfo : IScriptable
	{
		private CInt32 _number;
		private CString _kind;
		private CString _hostname;
		private CString _address;
		private CString _worldDescription;

		[Ordinal(0)] 
		[RED("number")] 
		public CInt32 Number
		{
			get
			{
				if (_number == null)
				{
					_number = (CInt32) CR2WTypeManager.Create("Int32", "number", cr2w, this);
				}
				return _number;
			}
			set
			{
				if (_number == value)
				{
					return;
				}
				_number = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("kind")] 
		public CString Kind
		{
			get
			{
				if (_kind == null)
				{
					_kind = (CString) CR2WTypeManager.Create("String", "kind", cr2w, this);
				}
				return _kind;
			}
			set
			{
				if (_kind == value)
				{
					return;
				}
				_kind = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hostname")] 
		public CString Hostname
		{
			get
			{
				if (_hostname == null)
				{
					_hostname = (CString) CR2WTypeManager.Create("String", "hostname", cr2w, this);
				}
				return _hostname;
			}
			set
			{
				if (_hostname == value)
				{
					return;
				}
				_hostname = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("address")] 
		public CString Address
		{
			get
			{
				if (_address == null)
				{
					_address = (CString) CR2WTypeManager.Create("String", "address", cr2w, this);
				}
				return _address;
			}
			set
			{
				if (_address == value)
				{
					return;
				}
				_address = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("worldDescription")] 
		public CString WorldDescription
		{
			get
			{
				if (_worldDescription == null)
				{
					_worldDescription = (CString) CR2WTypeManager.Create("String", "worldDescription", cr2w, this);
				}
				return _worldDescription;
			}
			set
			{
				if (_worldDescription == value)
				{
					return;
				}
				_worldDescription = value;
				PropertySet(this);
			}
		}

		public inkServerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
