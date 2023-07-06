using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAudioNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIAudioNodeType>>();
			set => SetPropertyValue<CHandle<questIAudioNodeType>>(value);
		}

		public questAudioNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
