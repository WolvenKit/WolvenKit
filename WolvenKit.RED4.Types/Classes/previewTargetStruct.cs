using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class previewTargetStruct : RedBaseClass
	{
		private CWeakHandle<gameObject> _currentlyTrackedTarget;
		private CEnum<EHitReactionZone> _currentBodyPart;

		[Ordinal(0)] 
		[RED("currentlyTrackedTarget")] 
		public CWeakHandle<gameObject> CurrentlyTrackedTarget
		{
			get => GetProperty(ref _currentlyTrackedTarget);
			set => SetProperty(ref _currentlyTrackedTarget, value);
		}

		[Ordinal(1)] 
		[RED("currentBodyPart")] 
		public CEnum<EHitReactionZone> CurrentBodyPart
		{
			get => GetProperty(ref _currentBodyPart);
			set => SetProperty(ref _currentBodyPart, value);
		}
	}
}
