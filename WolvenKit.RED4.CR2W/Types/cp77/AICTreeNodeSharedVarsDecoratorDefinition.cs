using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private AISharedVarTableDefinition _sharedVars;

		[Ordinal(1)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get
			{
				if (_sharedVars == null)
				{
					_sharedVars = (AISharedVarTableDefinition) CR2WTypeManager.Create("AISharedVarTableDefinition", "sharedVars", cr2w, this);
				}
				return _sharedVars;
			}
			set
			{
				if (_sharedVars == value)
				{
					return;
				}
				_sharedVars = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeSharedVarsDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
