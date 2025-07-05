using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ParticleBurst : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("burstTime")] 
		public CFloat BurstTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("spawnCount")] 
		public CUInt32 SpawnCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("spawnTimeRange")] 
		public CFloat SpawnTimeRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("repeatTime")] 
		public CFloat RepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ParticleBurst()
		{
			SpawnCount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
