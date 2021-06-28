using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalCondition : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		private CName _signalName;

		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		public AIStackSignalCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
