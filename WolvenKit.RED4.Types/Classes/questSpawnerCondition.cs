using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnerCondition : questTypedCondition
	{
		private CHandle<questISpawnerConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISpawnerConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
