using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		private CBool _isPreview;
		private CBool _sendNearMissEvents;

		[Ordinal(0)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetProperty(ref _isPreview);
			set => SetProperty(ref _isPreview, value);
		}

		[Ordinal(1)] 
		[RED("sendNearMissEvents")] 
		public CBool SendNearMissEvents
		{
			get => GetProperty(ref _sendNearMissEvents);
			set => SetProperty(ref _sendNearMissEvents, value);
		}

		public gameEffectObjectFilter_HitRepresentation_Raycast()
		{
			_sendNearMissEvents = true;
		}
	}
}
