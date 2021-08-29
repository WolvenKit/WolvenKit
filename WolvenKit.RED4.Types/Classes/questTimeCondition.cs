using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTimeCondition : questTypedCondition
	{
		private CHandle<questITimeConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questITimeConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
