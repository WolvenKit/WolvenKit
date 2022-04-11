using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterTimetableRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get => GetPropertyValue<PSOwnerData>();
			set => SetPropertyValue<PSOwnerData>(value);
		}

		public UnregisterTimetableRequest()
		{
			RequesterData = new() { Id = new() };
		}
	}
}
