using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneCondition : questTypedCondition
	{
		private CHandle<questISceneConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISceneConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
