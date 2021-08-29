using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityCondition : questTypedCondition
	{
		private CHandle<questIEntityConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIEntityConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
