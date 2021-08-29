using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineRequestManager : IScriptable
	{
		private CArray<CHandle<OutlineRequest>> _requestsList;
		private CWeakHandle<gameObject> _owner;
		private CBool _isBlocked;
		private CArray<CHandle<OutlineRequest>> _dbgRequests;

		[Ordinal(0)] 
		[RED("requestsList")] 
		public CArray<CHandle<OutlineRequest>> RequestsList
		{
			get => GetProperty(ref _requestsList);
			set => SetProperty(ref _requestsList, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(3)] 
		[RED("dbgRequests")] 
		public CArray<CHandle<OutlineRequest>> DbgRequests
		{
			get => GetProperty(ref _dbgRequests);
			set => SetProperty(ref _dbgRequests, value);
		}
	}
}
