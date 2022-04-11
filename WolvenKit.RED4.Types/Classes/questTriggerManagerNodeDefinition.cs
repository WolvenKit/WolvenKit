using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTriggerManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questITriggerManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questITriggerManagerNodeType>>();
			set => SetPropertyValue<CHandle<questITriggerManagerNodeType>>(value);
		}

		public questTriggerManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
