using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		private CName _audioMetadata;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;

		[Ordinal(3)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(4)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get => GetProperty(ref _destructionParams);
			set => SetProperty(ref _destructionParams, value);
		}

		[Ordinal(5)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get => GetProperty(ref _destructionLevelData);
			set => SetProperty(ref _destructionLevelData, value);
		}

		public worldFoliagePhysicalDestructionMapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
