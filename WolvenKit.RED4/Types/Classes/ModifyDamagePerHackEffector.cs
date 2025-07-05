using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamagePerHackEffector : ModifyDamageEffector
	{
		[Ordinal(6)] 
		[RED("countOnlyUnique")] 
		public CBool CountOnlyUnique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModifyDamagePerHackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
