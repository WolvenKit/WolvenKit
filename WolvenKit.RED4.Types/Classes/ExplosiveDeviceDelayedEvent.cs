using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveDeviceDelayedEvent : redEvent
	{
		private CInt32 _arrayIndex;
		private CWeakHandle<gameObject> _instigator;

		[Ordinal(0)] 
		[RED("arrayIndex")] 
		public CInt32 ArrayIndex
		{
			get => GetProperty(ref _arrayIndex);
			set => SetProperty(ref _arrayIndex, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}
	}
}
