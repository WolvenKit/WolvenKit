using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionRotateToObjectState : gameActionRotateBaseState
	{
		private CWeakHandle<gameObject> _targetObject;
		private CBool _completeWhenRotated;

		[Ordinal(11)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(12)] 
		[RED("completeWhenRotated")] 
		public CBool CompleteWhenRotated
		{
			get => GetProperty(ref _completeWhenRotated);
			set => SetProperty(ref _completeWhenRotated, value);
		}
	}
}
