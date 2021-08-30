using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class enteventsPhysicalImpulseEvent : redEvent
	{
		private CUInt32 _bodyIndex;
		private Vector3 _worldImpulse;
		private Vector3 _worldPosition;
		private CFloat _radius;
		private CUInt32 _shapeIndex;

		[Ordinal(0)] 
		[RED("bodyIndex")] 
		public CUInt32 BodyIndex
		{
			get => GetProperty(ref _bodyIndex);
			set => SetProperty(ref _bodyIndex, value);
		}

		[Ordinal(1)] 
		[RED("worldImpulse")] 
		public Vector3 WorldImpulse
		{
			get => GetProperty(ref _worldImpulse);
			set => SetProperty(ref _worldImpulse, value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(4)] 
		[RED("shapeIndex")] 
		public CUInt32 ShapeIndex
		{
			get => GetProperty(ref _shapeIndex);
			set => SetProperty(ref _shapeIndex, value);
		}

		public enteventsPhysicalImpulseEvent()
		{
			_bodyIndex = 4294967295;
		}
	}
}
