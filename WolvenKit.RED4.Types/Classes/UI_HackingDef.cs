using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HackingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _ammoIndicator;

		[Ordinal(0)] 
		[RED("ammoIndicator")] 
		public gamebbScriptID_Bool AmmoIndicator
		{
			get => GetProperty(ref _ammoIndicator);
			set => SetProperty(ref _ammoIndicator, value);
		}
	}
}
