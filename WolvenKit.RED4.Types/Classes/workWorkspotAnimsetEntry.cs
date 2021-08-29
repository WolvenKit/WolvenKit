using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotAnimsetEntry : RedBaseClass
	{
		private CResourceAsyncReference<animRig> _rig;
		private animAnimSetup _animations;
		private CArray<CResourceReference<animAnimSet>> _loadingHandles;

		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(2)] 
		[RED("loadingHandles")] 
		public CArray<CResourceReference<animAnimSet>> LoadingHandles
		{
			get => GetProperty(ref _loadingHandles);
			set => SetProperty(ref _loadingHandles, value);
		}
	}
}
