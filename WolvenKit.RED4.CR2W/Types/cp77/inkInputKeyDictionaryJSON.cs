using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputKeyDictionaryJSON : ISerializable
	{
		private CArray<inkInputDevicesMappingsJSON> _devicesMappings;

		[Ordinal(0)] 
		[RED("devicesMappings")] 
		public CArray<inkInputDevicesMappingsJSON> DevicesMappings
		{
			get
			{
				if (_devicesMappings == null)
				{
					_devicesMappings = (CArray<inkInputDevicesMappingsJSON>) CR2WTypeManager.Create("array:inkInputDevicesMappingsJSON", "devicesMappings", cr2w, this);
				}
				return _devicesMappings;
			}
			set
			{
				if (_devicesMappings == value)
				{
					return;
				}
				_devicesMappings = value;
				PropertySet(this);
			}
		}

		public inkInputKeyDictionaryJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
