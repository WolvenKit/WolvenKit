using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionAgents : IScriptable
	{
		[Ordinal(0)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("requsteredAgents")] 
		public CArray<CHandle<SPreventionAgentData>> RequsteredAgents
		{
			get => GetPropertyValue<CArray<CHandle<SPreventionAgentData>>>();
			set => SetPropertyValue<CArray<CHandle<SPreventionAgentData>>>(value);
		}

		public PreventionAgents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
