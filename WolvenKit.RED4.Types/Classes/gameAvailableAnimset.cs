using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAvailableAnimset : RedBaseClass
	{
		private CUInt64 _hash;
		private CString _resourcePath;

		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("resourcePath")] 
		public CString ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		public gameAvailableAnimset()
		{
			_resourcePath = new() { Text = "Unknown" };
		}
	}
}
