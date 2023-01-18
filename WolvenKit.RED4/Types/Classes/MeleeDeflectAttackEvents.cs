using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(9)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeDeflectAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
