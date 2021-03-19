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
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		[Ordinal(2)] 
		[RED("scriptName")] 
		public CName ScriptName
		{
			get => GetProperty(ref _scriptName);
			set => SetProperty(ref _scriptName, value);
		}

		public AICTreeNodeScriptDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
