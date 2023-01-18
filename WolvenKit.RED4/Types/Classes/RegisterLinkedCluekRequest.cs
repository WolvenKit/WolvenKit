using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetPropertyValue<LinkedFocusClueData>();
			set => SetPropertyValue<LinkedFocusClueData>(value);
		}

		[Ordinal(1)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RegisterLinkedCluekRequest()
		{
			LinkedCluekData = new() { OwnerID = new(), ExtendedClueRecords = new(), PsData = new() { Id = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
