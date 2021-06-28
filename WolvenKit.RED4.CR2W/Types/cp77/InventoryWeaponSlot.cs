using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponSlot : InventoryEquipmentSlot
	{
		private inkWidgetReference _damageIndicatorRef;
		private inkWidgetReference _dPSRef;
		private inkTextWidgetReference _dPSValueLabel;
		private wCHandle<DamageTypeIndicator> _damageTypeIndicator;
		private CBool _introPlayed;

		[Ordinal(17)] 
		[RED("DamageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetProperty(ref _damageIndicatorRef);
			set => SetProperty(ref _damageIndicatorRef, value);
		}

		[Ordinal(18)] 
		[RED("DPSRef")] 
		public inkWidgetReference DPSRef
		{
			get => GetProperty(ref _dPSRef);
			set => SetProperty(ref _dPSRef, value);
		}

		[Ordinal(19)] 
		[RED("DPSValueLabel")] 
		public inkTextWidgetReference DPSValueLabel
		{
			get => GetProperty(ref _dPSValueLabel);
			set => SetProperty(ref _dPSValueLabel, value);
		}

		[Ordinal(20)] 
		[RED("DamageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetProperty(ref _damageTypeIndicator);
			set => SetProperty(ref _damageTypeIndicator, value);
		}

		[Ordinal(21)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get => GetProperty(ref _introPlayed);
			set => SetProperty(ref _introPlayed, value);
		}

		public InventoryWeaponSlot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
