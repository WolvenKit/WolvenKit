using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ParticleBurst : RedBaseClass
	{
		private CFloat _burstTime;
		private CUInt32 _spawnCount;
		private CFloat _spawnTimeRange;
		private CFloat _repeatTime;

		[Ordinal(0)] 
		[RED("burstTime")] 
		public CFloat BurstTime
		{
			get => GetProperty(ref _burstTime);
			set => SetProperty(ref _burstTime, value);
		}

		[Ordinal(1)] 
		[RED("spawnCount")] 
		public CUInt32 SpawnCount
		{
			get => GetProperty(ref _spawnCount);
			set => SetProperty(ref _spawnCount, value);
		}

		[Ordinal(2)] 
		[RED("spawnTimeRange")] 
		public CFloat SpawnTimeRange
		{
			get => GetProperty(ref _spawnTimeRange);
			set => SetProperty(ref _spawnTimeRange, value);
		}

		[Ordinal(3)] 
		[RED("repeatTime")] 
		public CFloat RepeatTime
		{
			get => GetProperty(ref _repeatTime);
			set => SetProperty(ref _repeatTime, value);
		}

		public ParticleBurst()
		{
			_spawnCount = 1;
		}
	}
}
