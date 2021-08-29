using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionAgents : IScriptable
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
	}
}
