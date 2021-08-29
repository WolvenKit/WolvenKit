using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardChangedEvent : redEvent
	{
		private CHandle<gamebbScriptDefinition> _definition;
		private gamebbScriptID _id;

		[Ordinal(0)] 
		[RED("definition")] 
		public CHandle<gamebbScriptDefinition> Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public gamebbScriptID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
