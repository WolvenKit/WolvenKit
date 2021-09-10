using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestStackPassiveExpression : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("SomeNameProperty")] 
		public CName SomeNameProperty
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
