using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBlackboardChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("definition")] 
		public CHandle<gamebbScriptDefinition> Definition
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public gamebbScriptID Id
		{
			get => GetPropertyValue<gamebbScriptID>();
			set => SetPropertyValue<gamebbScriptID>(value);
		}

		public gameBlackboardChangedEvent()
		{
			Id = new() { None = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
