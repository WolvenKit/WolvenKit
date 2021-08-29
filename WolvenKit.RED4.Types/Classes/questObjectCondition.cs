using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectCondition : questTypedCondition
	{
		private CHandle<questIObjectConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIObjectConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
