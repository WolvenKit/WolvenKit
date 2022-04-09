using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workScriptedCondition : workIWorkspotCondition
	{
		[Ordinal(2)] 
		[RED("script")] 
		public CHandle<workIScriptedCondition> Script
		{
			get => GetPropertyValue<CHandle<workIScriptedCondition>>();
			set => SetPropertyValue<CHandle<workIScriptedCondition>>(value);
		}

		public workScriptedCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
