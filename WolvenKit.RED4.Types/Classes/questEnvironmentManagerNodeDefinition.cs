using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnvironmentManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIEnvironmentManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIEnvironmentManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIEnvironmentManagerNodeType>>(value);
		}

		public questEnvironmentManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
