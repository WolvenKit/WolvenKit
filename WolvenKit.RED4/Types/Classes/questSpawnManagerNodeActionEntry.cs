using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSpawnManagerNodeActionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questSpawnManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questSpawnManagerNodeType>>();
			set => SetPropertyValue<CHandle<questSpawnManagerNodeType>>(value);
		}

		public questSpawnManagerNodeActionEntry()
		{
			Type = new questSpawnSet_NodeType();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
