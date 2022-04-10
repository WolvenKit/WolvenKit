using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRotateToNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questRotateToParams> Params
		{
			get => GetPropertyValue<CHandle<questRotateToParams>>();
			set => SetPropertyValue<CHandle<questRotateToParams>>(value);
		}

		public questRotateToNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			EntityReference = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
