using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class enteventsPhysicalCollisionEvent : redEvent
	{
		private CWeakHandle<IScriptable> _myComponent;
		private CWeakHandle<IScriptable> _otherEntity;
		private CWeakHandle<IScriptable> _otherComponent;
		private Vector4 _worldPosition;
		private Vector4 _worldNormal;
		private Vector4 _deltaVelocity;
		private CFloat _impulse;

		[Ordinal(0)] 
		[RED("myComponent")] 
		public CWeakHandle<IScriptable> MyComponent
		{
			get => GetProperty(ref _myComponent);
			set => SetProperty(ref _myComponent, value);
		}

		[Ordinal(1)] 
		[RED("otherEntity")] 
		public CWeakHandle<IScriptable> OtherEntity
		{
			get => GetProperty(ref _otherEntity);
			set => SetProperty(ref _otherEntity, value);
		}

		[Ordinal(2)] 
		[RED("otherComponent")] 
		public CWeakHandle<IScriptable> OtherComponent
		{
			get => GetProperty(ref _otherComponent);
			set => SetProperty(ref _otherComponent, value);
		}

		[Ordinal(3)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(4)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		[Ordinal(5)] 
		[RED("deltaVelocity")] 
		public Vector4 DeltaVelocity
		{
			get => GetProperty(ref _deltaVelocity);
			set => SetProperty(ref _deltaVelocity, value);
		}

		[Ordinal(6)] 
		[RED("impulse")] 
		public CFloat Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}
	}
}
