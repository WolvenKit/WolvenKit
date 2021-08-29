using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatSaveData : RedBaseClass
	{
		private entEntityID _entityId;
		private CUInt32 _persistenceSourceBitMask;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("persistenceSourceBitMask")] 
		public CUInt32 PersistenceSourceBitMask
		{
			get => GetProperty(ref _persistenceSourceBitMask);
			set => SetProperty(ref _persistenceSourceBitMask, value);
		}
	}
}
