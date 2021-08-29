using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedItem : RedBaseClass
	{
		private CWeakHandle<entEntity> _entity;
		private netTime _netTime;

		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("netTime")] 
		public netTime NetTime
		{
			get => GetProperty(ref _netTime);
			set => SetProperty(ref _netTime, value);
		}
	}
}
