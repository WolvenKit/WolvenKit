using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterTimetableRequest : gameScriptableSystemRequest
	{
		private PSOwnerData _requesterData;

		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get => GetProperty(ref _requesterData);
			set => SetProperty(ref _requesterData, value);
		}
	}
}
