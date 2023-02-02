
namespace WolvenKit.RED4.Types
{
	public partial class questAudioCharacterManagerFootsteps_NodeSubType : questIAudioCharacterManager_NodeSubType
	{
		public questAudioCharacterManagerFootsteps_NodeSubType()
		{
			CharacterEntries = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
