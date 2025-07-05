using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeBlockEvents : MeleeRumblingEvents
	{
		[Ordinal(2)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public MeleeBlockEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
