using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BeamData : RedBaseClass
	{
		private Vector4 _startDirection;
		private Vector4 _endDirection;
		private CHandle<gameEffectInstance> _effect;
		private CWeakHandle<gameObject> _target;

		[Ordinal(0)] 
		[RED("startDirection")] 
		public Vector4 StartDirection
		{
			get => GetProperty(ref _startDirection);
			set => SetProperty(ref _startDirection, value);
		}

		[Ordinal(1)] 
		[RED("endDirection")] 
		public Vector4 EndDirection
		{
			get => GetProperty(ref _endDirection);
			set => SetProperty(ref _endDirection, value);
		}

		[Ordinal(2)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
