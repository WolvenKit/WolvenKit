using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("takeControlSourceID")] 
		public entEntityID TakeControlSourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("isInputRegistered")] 
		public CBool IsInputRegistered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isInputLockedFromQuest")] 
		public CBool IsInputLockedFromQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isChainForcedFromQuest")] 
		public CBool IsChainForcedFromQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isActionButtonLocked")] 
		public CBool IsActionButtonLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isDeviceChainCreationLocked")] 
		public CBool IsDeviceChainCreationLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("chainLockSources")] 
		public CArray<CName> ChainLockSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("TCDUpdateDelayID")] 
		public gameDelayID TCDUpdateDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(9)] 
		[RED("TCSupdateRate")] 
		public CFloat TCSupdateRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("lastInputSimTime")] 
		public CFloat LastInputSimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TakeOverControlSystem()
		{
			TakeControlSourceID = new();
			ChainLockSources = new();
			TCDUpdateDelayID = new();
			TCSupdateRate = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
