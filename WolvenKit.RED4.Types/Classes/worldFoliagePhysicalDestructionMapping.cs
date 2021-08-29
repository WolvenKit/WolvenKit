using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		private CName _audioMetadata;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;

		[Ordinal(2)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(3)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetProperty(ref _destructionParams);
			set => SetProperty(ref _destructionParams, value);
		}

		[Ordinal(4)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetProperty(ref _destructionLevelData);
			set => SetProperty(ref _destructionLevelData, value);
		}
	}
}
