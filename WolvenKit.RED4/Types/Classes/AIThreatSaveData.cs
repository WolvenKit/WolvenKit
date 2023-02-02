using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIThreatSaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("persistenceSourceBitMask")] 
		public CUInt32 PersistenceSourceBitMask
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AIThreatSaveData()
		{
			EntityId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
