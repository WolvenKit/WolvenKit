using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questContentCondition : questTypedCondition
	{
		private CHandle<questIContentConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIContentConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
