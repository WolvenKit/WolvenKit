using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeScriptDecoratorDefinition : AICTreeExtendableNodeDefinition
	{
		private CHandle<gameActionScript> _script;
		private CName _scriptName;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<gameActionScript> Script
		{
			get
			{
				if (_script == null)
				{
					_script = (CHandle<gameActionScript>) CR2WTypeManager.Create("handle:gameActionScript", "script", cr2w, this);
				}
				return _script;
			}
			set
			{
				if (_script == value)
				{
					return;
				}
				_script = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scriptName")] 
		public CName ScriptName
		{
			get
			{
				if (_scriptName == null)
				{
					_scriptName = (CName) CR2WTypeManager.Create("CName", "scriptName", cr2w, this);
				}
				return _scriptName;
			}
			set
			{
				if (_scriptName == value)
				{
					return;
				}
				_scriptName = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeScriptDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
