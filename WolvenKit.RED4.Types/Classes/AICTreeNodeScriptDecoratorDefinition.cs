using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeScriptDecoratorDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<gameActionScript> Script
		{
			get => GetPropertyValue<CHandle<gameActionScript>>();
			set => SetPropertyValue<CHandle<gameActionScript>>(value);
		}

		[Ordinal(2)] 
		[RED("scriptName")] 
		public CName ScriptName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AICTreeNodeScriptDecoratorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
