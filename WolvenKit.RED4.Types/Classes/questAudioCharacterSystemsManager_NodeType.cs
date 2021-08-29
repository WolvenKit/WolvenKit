using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioCharacterSystemsManager_NodeType : questIAudioCharacterManager_NodeType
	{
		private CHandle<questIAudioCharacterManager_NodeSubType> _subType;

		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questIAudioCharacterManager_NodeSubType> SubType
		{
			get => GetProperty(ref _subType);
			set => SetProperty(ref _subType, value);
		}
	}
}
