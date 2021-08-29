using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestStackPassiveExpression : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		private CName _someNameProperty;

		[Ordinal(0)] 
		[RED("SomeNameProperty")] 
		public CName SomeNameProperty
		{
			get => GetProperty(ref _someNameProperty);
			set => SetProperty(ref _someNameProperty, value);
		}
	}
}
