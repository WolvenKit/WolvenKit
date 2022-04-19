using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkScreenProjection : IScriptable
	{
		[Ordinal(0)] 
		[RED("distanceToCamera")] 
		public CFloat DistanceToCamera
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("previousPosition")] 
		public Vector2 PreviousPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("currentPosition")] 
		public Vector2 CurrentPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("uvPosition")] 
		public Vector2 UvPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkScreenProjection()
		{
			PreviousPosition = new();
			CurrentPosition = new();
			UvPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
