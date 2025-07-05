using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVoicesetManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIVoicesetManager_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questIVoicesetManager_NodeType>>();
			set => SetPropertyValue<CHandle<questIVoicesetManager_NodeType>>(value);
		}

		public questVoicesetManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
