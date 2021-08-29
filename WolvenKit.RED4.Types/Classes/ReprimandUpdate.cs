using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReprimandUpdate : redEvent
	{
		private CEnum<EReprimandInstructions> _reprimandInstructions;
		private entEntityID _target;
		private Vector4 _targetPos;
		private CWeakHandle<gameObject> _currentPerformer;

		[Ordinal(0)] 
		[RED("reprimandInstructions")] 
		public CEnum<EReprimandInstructions> ReprimandInstructions
		{
			get => GetProperty(ref _reprimandInstructions);
			set => SetProperty(ref _reprimandInstructions, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetPos")] 
		public Vector4 TargetPos
		{
			get => GetProperty(ref _targetPos);
			set => SetProperty(ref _targetPos, value);
		}

		[Ordinal(3)] 
		[RED("currentPerformer")] 
		public CWeakHandle<gameObject> CurrentPerformer
		{
			get => GetProperty(ref _currentPerformer);
			set => SetProperty(ref _currentPerformer, value);
		}
	}
}
