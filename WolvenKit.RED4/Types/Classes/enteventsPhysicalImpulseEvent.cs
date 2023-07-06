using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsPhysicalImpulseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyIndex")] 
		public CUInt32 BodyIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("worldImpulse")] 
		public Vector3 WorldImpulse
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("shapeIndex")] 
		public CUInt32 ShapeIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public enteventsPhysicalImpulseEvent()
		{
			BodyIndex = uint.MaxValue;
			WorldImpulse = new Vector3();
			WorldPosition = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
