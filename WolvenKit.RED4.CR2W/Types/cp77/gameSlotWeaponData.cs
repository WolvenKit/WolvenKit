using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSlotWeaponData : CVariable
	{
		private gameItemID _weaponID;
		private CInt32 _ammoCurrent;
		private CInt32 _magazineCap;
		private gameItemID _ammoId;
		private CEnum<gamedataTriggerMode> _triggerModeCurrent;
		private CArray<CEnum<gamedataTriggerMode>> _triggerModeList;
		private CEnum<gamedataWeaponEvolution> _evolution;
		private CBool _isActive;
		private CBool _isFirstEquip;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public gameItemID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(1)] 
		[RED("ammoCurrent")] 
		public CInt32 AmmoCurrent
		{
			get => GetProperty(ref _ammoCurrent);
			set => SetProperty(ref _ammoCurrent, value);
		}

		[Ordinal(2)] 
		[RED("magazineCap")] 
		public CInt32 MagazineCap
		{
			get => GetProperty(ref _magazineCap);
			set => SetProperty(ref _magazineCap, value);
		}

		[Ordinal(3)] 
		[RED("ammoId")] 
		public gameItemID AmmoId
		{
			get => GetProperty(ref _ammoId);
			set => SetProperty(ref _ammoId, value);
		}

		[Ordinal(4)] 
		[RED("triggerModeCurrent")] 
		public CEnum<gamedataTriggerMode> TriggerModeCurrent
		{
			get => GetProperty(ref _triggerModeCurrent);
			set => SetProperty(ref _triggerModeCurrent, value);
		}

		[Ordinal(5)] 
		[RED("triggerModeList")] 
		public CArray<CEnum<gamedataTriggerMode>> TriggerModeList
		{
			get => GetProperty(ref _triggerModeList);
			set => SetProperty(ref _triggerModeList, value);
		}

		[Ordinal(6)] 
		[RED("evolution")] 
		public CEnum<gamedataWeaponEvolution> Evolution
		{
			get => GetProperty(ref _evolution);
			set => SetProperty(ref _evolution, value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(8)] 
		[RED("isFirstEquip")] 
		public CBool IsFirstEquip
		{
			get => GetProperty(ref _isFirstEquip);
			set => SetProperty(ref _isFirstEquip, value);
		}

		public gameSlotWeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
