using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceResourceData_ : ISerializable
	{
		private CUInt32 _version;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public gameDeviceResourceData_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
