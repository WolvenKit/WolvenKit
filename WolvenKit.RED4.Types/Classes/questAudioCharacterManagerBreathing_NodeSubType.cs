
namespace WolvenKit.RED4.Types
{
	public partial class questAudioCharacterManagerBreathing_NodeSubType : questIAudioCharacterManager_NodeSubType
	{
		public questAudioCharacterManagerBreathing_NodeSubType()
		{
			CharacterEntries = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
