using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnManagerNodeType : questIRetNodeType
	{
		private CEnum<populationSpawnerObjectCtrlAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<populationSpawnerObjectCtrlAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
