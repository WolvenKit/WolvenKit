using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUIManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIUIManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIUIManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIUIManagerNodeType>>(value);
		}

		public questUIManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
