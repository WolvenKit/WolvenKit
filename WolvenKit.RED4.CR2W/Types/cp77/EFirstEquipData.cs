using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EFirstEquipData : CVariable
	{
		private TweakDBID _weaponID;
		private CBool _hasPlayedFirstEquip;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(1)] 
		[RED("hasPlayedFirstEquip")] 
		public CBool HasPlayedFirstEquip
		{
			get => GetProperty(ref _hasPlayedFirstEquip);
			set => SetProperty(ref _hasPlayedFirstEquip, value);
		}

		public EFirstEquipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
