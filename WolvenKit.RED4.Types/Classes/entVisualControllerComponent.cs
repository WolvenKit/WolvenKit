using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVisualControllerComponent : entIComponent
	{
		private CResourceReference<CMesh> _meshProxy;
		private CArray<entVisualControllerDependency> _appearanceDependency;
		private CResourceAsyncReference<appearanceCookedAppearanceData> _cookedAppearanceData;
		private CEnum<entForcedLodDistance> _forcedLodDistance;

		[Ordinal(3)] 
		[RED("meshProxy")] 
		public CResourceReference<CMesh> MeshProxy
		{
			get => GetProperty(ref _meshProxy);
			set => SetProperty(ref _meshProxy, value);
		}

		[Ordinal(4)] 
		[RED("appearanceDependency")] 
		public CArray<entVisualControllerDependency> AppearanceDependency
		{
			get => GetProperty(ref _appearanceDependency);
			set => SetProperty(ref _appearanceDependency, value);
		}

		[Ordinal(5)] 
		[RED("cookedAppearanceData")] 
		public CResourceAsyncReference<appearanceCookedAppearanceData> CookedAppearanceData
		{
			get => GetProperty(ref _cookedAppearanceData);
			set => SetProperty(ref _cookedAppearanceData, value);
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetProperty(ref _forcedLodDistance);
			set => SetProperty(ref _forcedLodDistance, value);
		}
	}
}
