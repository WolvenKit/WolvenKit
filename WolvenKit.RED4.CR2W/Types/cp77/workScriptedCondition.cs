using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workScriptedCondition : workIWorkspotCondition
	{
		private CHandle<workIScriptedCondition> _script;

		[Ordinal(2)] 
		[RED("script")] 
		public CHandle<workIScriptedCondition> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		public workScriptedCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
