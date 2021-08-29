using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisarmComponent : gameScriptableComponent
	{
		private CBool _isDisarmingOngoing;
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<gameObject> _requester;

		[Ordinal(5)] 
		[RED("isDisarmingOngoing")] 
		public CBool IsDisarmingOngoing
		{
			get => GetProperty(ref _isDisarmingOngoing);
			set => SetProperty(ref _isDisarmingOngoing, value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(7)] 
		[RED("requester")] 
		public CWeakHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}
	}
}
