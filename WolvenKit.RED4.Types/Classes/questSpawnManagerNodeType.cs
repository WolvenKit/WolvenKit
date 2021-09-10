using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnManagerNodeType : questIRetNodeType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<populationSpawnerObjectCtrlAction> Action
		{
			get => GetPropertyValue<CEnum<populationSpawnerObjectCtrlAction>>();
			set => SetPropertyValue<CEnum<populationSpawnerObjectCtrlAction>>(value);
		}
	}
}
