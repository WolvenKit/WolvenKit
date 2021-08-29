using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnBeingTarget : redEvent
	{
		private CWeakHandle<gameObject> _objectThatTargets;
		private CBool _noLongerTarget;

		[Ordinal(0)] 
		[RED("objectThatTargets")] 
		public CWeakHandle<gameObject> ObjectThatTargets
		{
			get => GetProperty(ref _objectThatTargets);
			set => SetProperty(ref _objectThatTargets, value);
		}

		[Ordinal(1)] 
		[RED("noLongerTarget")] 
		public CBool NoLongerTarget
		{
			get => GetProperty(ref _noLongerTarget);
			set => SetProperty(ref _noLongerTarget, value);
		}
	}
}
