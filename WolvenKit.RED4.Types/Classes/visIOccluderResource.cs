using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class visIOccluderResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt32 ResourceHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
