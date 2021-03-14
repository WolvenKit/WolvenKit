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
			get
			{
				if (_damageIndicatorRef == null)
				{
					_damageIndicatorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "DamageIndicatorRef", cr2w, this);
				}
				return _damageIndicatorRef;
			}
			set
			{
				if (_damageIndicatorRef == value)
				{
					return;
				}
				_damageIndicatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("DPSRef")] 
		public inkWidgetReference DPSRef
		{
			get
			{
				if (_dPSRef == null)
				{
					_dPSRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "DPSRef", cr2w, this);
				}
				return _dPSRef;
			}
			set
			{
				if (_dPSRef == value)
				{
					return;
				}
				_dPSRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("DPSValueLabel")] 
		public inkTextWidgetReference DPSValueLabel
		{
			get
			{
				if (_dPSValueLabel == null)
				{
					_dPSValueLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DPSValueLabel", cr2w, this);
				}
				return _dPSValueLabel;
			}
			set
			{
				if (_dPSValueLabel == value)
				{
					return;
				}
				_dPSValueLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("DamageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get
			{
				if (_damageTypeIndicator == null)
				{
					_damageTypeIndicator = (wCHandle<DamageTypeIndicator>) CR2WTypeManager.Create("whandle:DamageTypeIndicator", "DamageTypeIndicator", cr2w, this);
				}
				return _damageTypeIndicator;
			}
			set
			{
				if (_damageTypeIndicator == value)
				{
					return;
				}
				_damageTypeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get
			{
				if (_introPlayed == null)
				{
					_introPlayed = (CBool) CR2WTypeManager.Create("Bool", "IntroPlayed", cr2w, this);
				}
				return _introPlayed;
			}
			set
			{
				if (_introPlayed == value)
				{
					return;
				}
				_introPlayed = value;
				PropertySet(this);
			}
		}

		public InventoryWeaponSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
