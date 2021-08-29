using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickMeleeDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _nPCHit;

		[Ordinal(0)] 
		[RED("NPCHit")] 
		public gamebbScriptID_Bool NPCHit
		{
			get => GetProperty(ref _nPCHit);
			set => SetProperty(ref _nPCHit, value);
		}
	}
}
