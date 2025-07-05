using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questWorldDataManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIWorldDataManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIWorldDataManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIWorldDataManagerNodeType>>(value);
		}

		public questWorldDataManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
