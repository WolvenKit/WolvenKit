using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakeOverControlSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("controlledObject")] 
		public CWeakHandle<gameObject> ControlledObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("isInputRegistered")] 
		public CBool IsInputRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isInputLockedFromQuest")] 
		public CBool IsInputLockedFromQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isChainForcedFromQuest")] 
		public CBool IsChainForcedFromQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isActionButtonLocked")] 
		public CBool IsActionButtonLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isDeviceChainCreationLocked")] 
		public CBool IsDeviceChainCreationLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("chainLockSources")] 
		public CArray<CName> ChainLockSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(7)] 
		[RED("TCDUpdateDelayID")] 
		public gameDelayID TCDUpdateDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(8)] 
		[RED("TCSupdateRate")] 
		public CFloat TCSupdateRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("lastInputSimTime")] 
		public CFloat LastInputSimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TakeOverControlSystem()
		{
			ChainLockSources = new();
			TCDUpdateDelayID = new();
			TCSupdateRate = 0.100000F;
		}
	}
}
