using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDamagePack : IScriptable
	{
		[Ordinal(0)] 
		[RED("damageList")] 
		public CArray<CHandle<gameDamage>> DamageList
		{
			get => GetPropertyValue<CArray<CHandle<gameDamage>>>();
			set => SetPropertyValue<CArray<CHandle<gameDamage>>>(value);
		}

		public gameDamagePack()
		{
			DamageList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
