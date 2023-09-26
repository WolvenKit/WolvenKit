using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicSpawnSystemNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIDynamicSpawnSystemType> Type
		{
			get => GetPropertyValue<CHandle<questIDynamicSpawnSystemType>>();
			set => SetPropertyValue<CHandle<questIDynamicSpawnSystemType>>(value);
		}

		public questDynamicSpawnSystemNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
