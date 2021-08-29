using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSensesCondition : questTypedCondition
	{
		private CHandle<questISensesConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISensesConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
