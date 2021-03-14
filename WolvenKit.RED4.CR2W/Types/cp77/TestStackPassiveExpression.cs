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
			get
			{
				if (_someNameProperty == null)
				{
					_someNameProperty = (CName) CR2WTypeManager.Create("CName", "SomeNameProperty", cr2w, this);
				}
				return _someNameProperty;
			}
			set
			{
				if (_someNameProperty == value)
				{
					return;
				}
				_someNameProperty = value;
				PropertySet(this);
			}
		}

		public TestStackPassiveExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
