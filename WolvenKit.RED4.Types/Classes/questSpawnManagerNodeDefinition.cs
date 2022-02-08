using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Id = 65535;
			Actions = new() { new() };
		}
	}
}
