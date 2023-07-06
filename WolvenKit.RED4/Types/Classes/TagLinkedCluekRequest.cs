using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TagLinkedCluekRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CBool Tag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetPropertyValue<LinkedFocusClueData>();
			set => SetPropertyValue<LinkedFocusClueData>(value);
		}

		public TagLinkedCluekRequest()
		{
			LinkedCluekData = new LinkedFocusClueData { OwnerID = new entEntityID(), ExtendedClueRecords = new(), PsData = new PSOwnerData { Id = new gamePersistentID() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
