using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBreachUIParameters : IScriptable
	{
		[Ordinal(0)] 
		[RED("trackingChange")] 
		public CEnum<gameBreachUITrackingChange> TrackingChange
		{
			get => GetPropertyValue<CEnum<gameBreachUITrackingChange>>();
			set => SetPropertyValue<CEnum<gameBreachUITrackingChange>>(value);
		}

		[Ordinal(1)] 
		[RED("tracking")] 
		public CBool Tracking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("almostTimeout")] 
		public CBool AlmostTimeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBreachUIParameters()
		{
			Position = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
