using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITrackedLocation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lastKnown")] 
		public AILocationInformation LastKnown
		{
			get => GetPropertyValue<AILocationInformation>();
			set => SetPropertyValue<AILocationInformation>(value);
		}

		[Ordinal(1)] 
		[RED("location")] 
		public AILocationInformation Location
		{
			get => GetPropertyValue<AILocationInformation>();
			set => SetPropertyValue<AILocationInformation>(value);
		}

		[Ordinal(2)] 
		[RED("sharedLocation")] 
		public AILocationInformation SharedLocation
		{
			get => GetPropertyValue<AILocationInformation>();
			set => SetPropertyValue<AILocationInformation>(value);
		}

		[Ordinal(3)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(4)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("sharedAccuracy")] 
		public CFloat SharedAccuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("sharedTimeDelay")] 
		public CFloat SharedTimeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("threat")] 
		public CFloat Threat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("speed")] 
		public Vector4 Speed
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("invalidExpectation")] 
		public CBool InvalidExpectation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("status")] 
		public CEnum<AITrackedStatusType> Status
		{
			get => GetPropertyValue<CEnum<AITrackedStatusType>>();
			set => SetPropertyValue<CEnum<AITrackedStatusType>>(value);
		}

		[Ordinal(12)] 
		[RED("sharedLastKnown")] 
		public AILocationInformation SharedLastKnown
		{
			get => GetPropertyValue<AILocationInformation>();
			set => SetPropertyValue<AILocationInformation>(value);
		}

		public AITrackedLocation()
		{
			LastKnown = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } };
			Location = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } };
			SharedLocation = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } };
			Accuracy = 1.000000F;
			SharedAccuracy = 1.000000F;
			Speed = new Vector4();
			SharedLastKnown = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
