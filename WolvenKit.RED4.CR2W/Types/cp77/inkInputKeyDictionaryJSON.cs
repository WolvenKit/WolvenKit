using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputKeyDictionaryJSON : ISerializable
	{
		[Ordinal(0)] [RED("devicesMappings")] public CArray<inkInputDevicesMappingsJSON> DevicesMappings { get; set; }

		public inkInputKeyDictionaryJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
