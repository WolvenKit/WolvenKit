using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWeakSpotReplicatedInfo : RedBaseClass
	{
		private CUInt64 _weakSpotRecordID;
		private CFloat _wsHealthValue;
		private CWeakHandle<gamePuppet> _lastDamageInstigator;

		[Ordinal(0)] 
		[RED("weakSpotRecordID")] 
		public CUInt64 WeakSpotRecordID
		{
			get => GetProperty(ref _weakSpotRecordID);
			set => SetProperty(ref _weakSpotRecordID, value);
		}

		[Ordinal(1)] 
		[RED("wsHealthValue")] 
		public CFloat WsHealthValue
		{
			get => GetProperty(ref _wsHealthValue);
			set => SetProperty(ref _wsHealthValue, value);
		}

		[Ordinal(2)] 
		[RED("LastDamageInstigator")] 
		public CWeakHandle<gamePuppet> LastDamageInstigator
		{
			get => GetProperty(ref _lastDamageInstigator);
			set => SetProperty(ref _lastDamageInstigator, value);
		}

		public gameWeakSpotReplicatedInfo()
		{
			_wsHealthValue = 100.000000F;
		}
	}
}
