using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetMortalityListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<PuppetMortalPrereqState> State
		{
			get => GetPropertyValue<CHandle<PuppetMortalPrereqState>>();
			set => SetPropertyValue<CHandle<PuppetMortalPrereqState>>(value);
		}
	}
}
