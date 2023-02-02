using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetPropertyValue<LinkedFocusClueData>();
			set => SetPropertyValue<LinkedFocusClueData>(value);
		}

		public UnregisterLinkedCluekRequest()
		{
			LinkedCluekData = new() { OwnerID = new(), ExtendedClueRecords = new(), PsData = new() { Id = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
