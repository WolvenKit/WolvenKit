using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questITimeManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questITimeManagerNodeType>>();
			set => SetPropertyValue<CHandle<questITimeManagerNodeType>>(value);
		}

		public questTimeManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
