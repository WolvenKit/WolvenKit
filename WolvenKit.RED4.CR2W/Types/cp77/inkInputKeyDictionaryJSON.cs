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
			get => GetProperty(ref _devicesMappings);
			set => SetProperty(ref _devicesMappings, value);
		}

		public inkInputKeyDictionaryJSON(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
