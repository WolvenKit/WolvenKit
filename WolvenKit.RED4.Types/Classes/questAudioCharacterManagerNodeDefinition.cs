using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioCharacterManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIAudioCharacterManager_NodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAudioCharacterManager_NodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
