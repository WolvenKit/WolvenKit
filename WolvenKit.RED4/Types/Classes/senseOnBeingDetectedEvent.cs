using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseOnBeingDetectedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<senseSensorObject> Source
		{
			get => GetPropertyValue<CWeakHandle<senseSensorObject>>();
			set => SetPropertyValue<CWeakHandle<senseSensorObject>>(value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public senseOnBeingDetectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
