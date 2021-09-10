using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Id = 65535;
		}
	}
}
