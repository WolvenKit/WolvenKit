using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldListResourceEntry : RedBaseClass
	{
		private CResourceAsyncReference<CResource> _world;
		private CResourceAsyncReference<CResource> _streamingWorld;
		private CString _worldName;

		[Ordinal(0)] 
		[RED("world")] 
		public CResourceAsyncReference<CResource> World
		{
			get => GetProperty(ref _world);
			set => SetProperty(ref _world, value);
		}

		[Ordinal(1)] 
		[RED("streamingWorld")] 
		public CResourceAsyncReference<CResource> StreamingWorld
		{
			get => GetProperty(ref _streamingWorld);
			set => SetProperty(ref _streamingWorld, value);
		}

		[Ordinal(2)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get => GetProperty(ref _worldName);
			set => SetProperty(ref _worldName, value);
		}
	}
}
