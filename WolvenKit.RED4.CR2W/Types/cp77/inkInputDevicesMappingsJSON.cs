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
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<inkInputIconMappingJSON> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}

		public inkInputDevicesMappingsJSON(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
