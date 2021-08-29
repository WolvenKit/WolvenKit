using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDamagePack : IScriptable
	{
		private CArray<CHandle<gameDamage>> _damageList;

		[Ordinal(0)] 
		[RED("damageList")] 
		public CArray<CHandle<gameDamage>> DamageList
		{
			get => GetProperty(ref _damageList);
			set => SetProperty(ref _damageList, value);
		}
	}
}
