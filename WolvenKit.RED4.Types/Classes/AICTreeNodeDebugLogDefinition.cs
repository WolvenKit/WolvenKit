using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeDebugLogDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("timeOnScreen")] 
		public CFloat TimeOnScreen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("useVisualDebug")] 
		public CBool UseVisualDebug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeDebugLogDefinition()
		{
			Text = "Activated!";
			TimeOnScreen = 2.000000F;
			UseVisualDebug = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
