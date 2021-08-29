using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class visIOccluderResource : ISerializable
	{
		private CUInt32 _resourceHash;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt32 ResourceHash
		{
			get => GetProperty(ref _resourceHash);
			set => SetProperty(ref _resourceHash, value);
		}
	}
}
