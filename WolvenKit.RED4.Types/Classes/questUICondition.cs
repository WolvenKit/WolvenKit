using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUICondition : questTypedCondition
	{
		private CHandle<questIUIConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIUIConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
