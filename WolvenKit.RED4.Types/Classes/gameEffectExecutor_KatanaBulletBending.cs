using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_KatanaBulletBending : gameEffectExecutor_Scripted
	{
		private CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> _effects;

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}
	}
}
