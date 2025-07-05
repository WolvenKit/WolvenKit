using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSpawnManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("actions")] 
		public CArray<questSpawnManagerNodeActionEntry> Actions
		{
			get => GetPropertyValue<CArray<questSpawnManagerNodeActionEntry>>();
			set => SetPropertyValue<CArray<questSpawnManagerNodeActionEntry>>(value);
		}

		public questSpawnManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			Actions = new() { new questSpawnManagerNodeActionEntry() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
