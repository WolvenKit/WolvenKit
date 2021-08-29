using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModeSystemRevealIdentifier : RedBaseClass
	{
		private entEntityID _sourceEntityId;
		private CName _reason;

		[Ordinal(0)] 
		[RED("sourceEntityId")] 
		public entEntityID SourceEntityId
		{
			get => GetProperty(ref _sourceEntityId);
			set => SetProperty(ref _sourceEntityId, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}
	}
}
