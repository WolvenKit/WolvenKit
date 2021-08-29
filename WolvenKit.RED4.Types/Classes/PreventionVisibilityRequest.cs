using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionVisibilityRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _requester;
		private CBool _seePlayer;

		[Ordinal(0)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("seePlayer")] 
		public CBool SeePlayer
		{
			get => GetProperty(ref _seePlayer);
			set => SetProperty(ref _seePlayer, value);
		}
	}
}
