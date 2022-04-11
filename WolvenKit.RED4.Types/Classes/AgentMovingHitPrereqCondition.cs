using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AgentMovingHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("object")] 
		public CName Object
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
