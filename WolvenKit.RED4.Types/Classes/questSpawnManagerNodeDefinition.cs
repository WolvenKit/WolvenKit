using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<questSpawnManagerNodeActionEntry> _actions;

		[Ordinal(2)] 
		[RED("actions")] 
		public CArray<questSpawnManagerNodeActionEntry> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}
	}
}
