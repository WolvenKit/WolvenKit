using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayEquipProgramsRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("programIDs")] 
		public CArray<gameItemID> ProgramIDs
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public GameplayEquipProgramsRequest()
		{
			ProgramIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
