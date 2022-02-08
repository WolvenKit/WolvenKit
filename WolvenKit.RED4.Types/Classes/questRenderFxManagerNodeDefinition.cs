using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRenderFxManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRenderFxManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIRenderFxManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIRenderFxManagerNodeType>>(value);
		}

		public questRenderFxManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
