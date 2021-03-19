using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGridCell : CVariable
	{
		private CInt32 _rarityValue;
		private CHandle<gamedataMiniGame_Trap_Record> _currentTrap;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("rarityValue")] 
		public CInt32 RarityValue
		{
			get => GetProperty(ref _rarityValue);
			set => SetProperty(ref _rarityValue, value);
		}

		[Ordinal(1)] 
		[RED("currentTrap")] 
		public CHandle<gamedataMiniGame_Trap_Record> CurrentTrap
		{
			get => GetProperty(ref _currentTrap);
			set => SetProperty(ref _currentTrap, value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public gameuiGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
