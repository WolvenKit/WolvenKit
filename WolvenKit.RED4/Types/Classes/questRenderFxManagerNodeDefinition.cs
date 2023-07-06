using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
