using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSingleSharedVarDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private LibTreeSharedVarRegistrationName _sharedVarName;

		[Ordinal(1)] 
		[RED("sharedVarName")] 
		public LibTreeSharedVarRegistrationName SharedVarName
		{
			get
			{
				if (_sharedVarName == null)
				{
					_sharedVarName = (LibTreeSharedVarRegistrationName) CR2WTypeManager.Create("LibTreeSharedVarRegistrationName", "sharedVarName", cr2w, this);
				}
				return _sharedVarName;
			}
			set
			{
				if (_sharedVarName == value)
				{
					return;
				}
				_sharedVarName = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeSingleSharedVarDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
