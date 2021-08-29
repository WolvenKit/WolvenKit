using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFactsDBCondition : questTypedCondition
	{
		private CHandle<questIFactsDBConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIFactsDBConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
