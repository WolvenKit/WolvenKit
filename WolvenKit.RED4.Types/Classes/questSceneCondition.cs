using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISceneConditionType> Type
		{
			get => GetPropertyValue<CHandle<questISceneConditionType>>();
			set => SetPropertyValue<CHandle<questISceneConditionType>>(value);
		}
	}
}
