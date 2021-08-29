using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkVideoRecord : ISerializable
	{
		private CUInt64 _resourceHash;
		private CFloat _binkDuration;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get => GetProperty(ref _resourceHash);
			set => SetProperty(ref _resourceHash, value);
		}

		[Ordinal(1)] 
		[RED("binkDuration")] 
		public CFloat BinkDuration
		{
			get => GetProperty(ref _binkDuration);
			set => SetProperty(ref _binkDuration, value);
		}
	}
}
