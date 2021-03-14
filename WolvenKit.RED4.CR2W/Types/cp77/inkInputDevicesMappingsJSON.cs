using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputDevicesMappingsJSON : CVariable
	{
		private CArray<CName> _devices;
		private CArray<inkInputIconMappingJSON> _mappings;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CName> Devices
		{
			get
			{
				if (_devices == null)
				{
					_devices = (CArray<CName>) CR2WTypeManager.Create("array:CName", "devices", cr2w, this);
				}
				return _devices;
			}
			set
			{
				if (_devices == value)
				{
					return;
				}
				_devices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<inkInputIconMappingJSON> Mappings
		{
			get
			{
				if (_mappings == null)
				{
					_mappings = (CArray<inkInputIconMappingJSON>) CR2WTypeManager.Create("array:inkInputIconMappingJSON", "mappings", cr2w, this);
				}
				return _mappings;
			}
			set
			{
				if (_mappings == value)
				{
					return;
				}
				_mappings = value;
				PropertySet(this);
			}
		}

		public inkInputDevicesMappingsJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
