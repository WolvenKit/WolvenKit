using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSDOClickedRequest : gameScriptableSystemRequest
	{
		private CName _fullPath;
		private CName _key;

		[Ordinal(0)] 
		[RED("fullPath")] 
		public CName FullPath
		{
			get => GetProperty(ref _fullPath);
			set => SetProperty(ref _fullPath, value);
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}
	}
}
