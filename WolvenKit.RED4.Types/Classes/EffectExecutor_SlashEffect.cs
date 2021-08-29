using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_SlashEffect : gameEffectExecutor_Scripted
	{
		private CArray<EffectExecutor_SlashEffect_Entry> _entries;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<EffectExecutor_SlashEffect_Entry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
