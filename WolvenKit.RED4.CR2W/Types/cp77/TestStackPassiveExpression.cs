using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestStackPassiveExpression : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		private CName _someNameProperty;

		[Ordinal(0)] 
		[RED("SomeNameProperty")] 
		public CName SomeNameProperty
		{
			get => GetProperty(ref _someNameProperty);
			set => SetProperty(ref _someNameProperty, value);
		}

		public TestStackPassiveExpression(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
