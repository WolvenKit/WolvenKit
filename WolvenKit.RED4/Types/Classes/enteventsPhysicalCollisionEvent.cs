using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsPhysicalCollisionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("myComponent")] 
		public CWeakHandle<IScriptable> MyComponent
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(1)] 
		[RED("otherEntity")] 
		public CWeakHandle<IScriptable> OtherEntity
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(2)] 
		[RED("otherComponent")] 
		public CWeakHandle<IScriptable> OtherComponent
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(3)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("deltaVelocity")] 
		public Vector4 DeltaVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("impulse")] 
		public CFloat Impulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public enteventsPhysicalCollisionEvent()
		{
			WorldPosition = new();
			WorldNormal = new() { Z = 1.000000F };
			DeltaVelocity = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
