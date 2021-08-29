using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemountingUnmountingEvent : redEvent
	{
		private CHandle<gamemountingUnmountingRequest> _request;
		private gamemountingMountingRelationship _relationship;

		[Ordinal(0)] 
		[RED("request")] 
		public CHandle<gamemountingUnmountingRequest> Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(1)] 
		[RED("relationship")] 
		public gamemountingMountingRelationship Relationship
		{
			get => GetProperty(ref _relationship);
			set => SetProperty(ref _relationship, value);
		}
	}
}
