using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateLinkedClueskRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetPropertyValue<LinkedFocusClueData>();
			set => SetPropertyValue<LinkedFocusClueData>(value);
		}

		public UpdateLinkedClueskRequest()
		{
			LinkedCluekData = new LinkedFocusClueData { OwnerID = new entEntityID(), ExtendedClueRecords = new(), PsData = new PSOwnerData { Id = new gamePersistentID() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
