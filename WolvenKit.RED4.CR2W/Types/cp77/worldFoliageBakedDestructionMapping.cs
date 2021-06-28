using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBakedDestructionMapping : worldFoliageDestructionMapping
	{
		private CFloat _numFrames;
		private CFloat _frameRate;
		private CName _audioMetadata;
		private raRef<worldEffect> _destructionEffect;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(2)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(3)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get => GetProperty(ref _frameRate);
			set => SetProperty(ref _frameRate, value);
		}

		[Ordinal(4)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(5)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get => GetProperty(ref _destructionEffect);
			set => SetProperty(ref _destructionEffect, value);
		}

		[Ordinal(6)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(7)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public worldFoliageBakedDestructionMapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
