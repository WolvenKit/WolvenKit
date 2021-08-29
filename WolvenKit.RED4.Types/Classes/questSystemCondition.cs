using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSystemCondition : questTypedCondition
	{
		private CHandle<questISystemConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISystemConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
