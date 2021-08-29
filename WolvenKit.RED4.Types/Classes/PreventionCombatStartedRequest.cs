using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionCombatStartedRequest : gameScriptableSystemRequest
	{
		private Vector4 _requesterPosition;
		private CWeakHandle<gameObject> _requester;

		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get => GetProperty(ref _requesterPosition);
			set => SetProperty(ref _requesterPosition, value);
		}

		[Ordinal(1)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}
	}
}
