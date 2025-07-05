using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_KatanaBulletBending : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects
		{
			get => GetPropertyValue<CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry>>();
			set => SetPropertyValue<CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry>>(value);
		}

		public gameEffectExecutor_KatanaBulletBending()
		{
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
