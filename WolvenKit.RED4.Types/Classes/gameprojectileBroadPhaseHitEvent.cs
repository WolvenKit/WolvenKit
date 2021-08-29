using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileBroadPhaseHitEvent : redEvent
	{
		private physicsTraceResult _traceResult;
		private Vector4 _position;
		private CWeakHandle<entEntity> _hitObject;
		private CWeakHandle<entIComponent> _hitComponent;

		[Ordinal(0)] 
		[RED("traceResult")] 
		public physicsTraceResult TraceResult
		{
			get => GetProperty(ref _traceResult);
			set => SetProperty(ref _traceResult, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("hitObject")] 
		public CWeakHandle<entEntity> HitObject
		{
			get => GetProperty(ref _hitObject);
			set => SetProperty(ref _hitObject, value);
		}

		[Ordinal(3)] 
		[RED("hitComponent")] 
		public CWeakHandle<entIComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}
	}
}
