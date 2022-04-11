using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileBroadPhaseHitEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("traceResult")] 
		public physicsTraceResult TraceResult
		{
			get => GetPropertyValue<physicsTraceResult>();
			set => SetPropertyValue<physicsTraceResult>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("hitObject")] 
		public CWeakHandle<entEntity> HitObject
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("hitComponent")] 
		public CWeakHandle<entIComponent> HitComponent
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		public gameprojectileBroadPhaseHitEvent()
		{
			TraceResult = new() { Position = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity }, Normal = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity } };
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
