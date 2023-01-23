using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransformAnimatorNode_Action_Skip : questTransformAnimatorNode_ActionType
	{
		[Ordinal(0)] 
		[RED("skipTo")] 
		public CFloat SkipTo
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questTransformAnimatorNode_Action_Skip()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
