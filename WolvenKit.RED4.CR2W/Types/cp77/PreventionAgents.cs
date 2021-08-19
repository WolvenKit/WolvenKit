using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionAgents : IScriptable
	{
		private CName _groupName;
		private CArray<CHandle<SPreventionAgentData>> _requsteredAgents;

		[Ordinal(0)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetProperty(ref _groupName);
			set => SetProperty(ref _groupName, value);
		}

		[Ordinal(1)] 
		[RED("requsteredAgents")] 
		public CArray<CHandle<SPreventionAgentData>> RequsteredAgents
		{
			get => GetProperty(ref _requsteredAgents);
			set => SetProperty(ref _requsteredAgents, value);
		}

		public PreventionAgents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
