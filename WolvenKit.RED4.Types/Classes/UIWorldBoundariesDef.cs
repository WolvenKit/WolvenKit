using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isPlayerCloseToBoundary;
		private gamebbScriptID_Bool _isPlayerGoingDeeper;

		[Ordinal(0)] 
		[RED("IsPlayerCloseToBoundary")] 
		public gamebbScriptID_Bool IsPlayerCloseToBoundary
		{
			get => GetProperty(ref _isPlayerCloseToBoundary);
			set => SetProperty(ref _isPlayerCloseToBoundary, value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerGoingDeeper")] 
		public gamebbScriptID_Bool IsPlayerGoingDeeper
		{
			get => GetProperty(ref _isPlayerGoingDeeper);
			set => SetProperty(ref _isPlayerGoingDeeper, value);
		}
	}
}
