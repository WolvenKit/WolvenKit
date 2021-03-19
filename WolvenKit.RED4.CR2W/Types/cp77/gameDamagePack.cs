using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamagePack : IScriptable
	{
		private CArray<CHandle<gameDamage>> _damageList;

		[Ordinal(0)] 
		[RED("damageList")] 
		public CArray<CHandle<gameDamage>> DamageList
		{
			get => GetProperty(ref _damageList);
			set => SetProperty(ref _damageList, value);
		}

		public gameDamagePack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
