using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyAttackCritChanceEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("applicationChanceMods")] 
		public CArray<CWeakHandle<gamedataStatModifier_Record>> ApplicationChanceMods
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>(value);
		}

		public ModifyAttackCritChanceEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
