using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponConfiguration : audioAudioMetadata
	{
		private audioMeleeSound _fastWhoosh;
		private audioMeleeSound _normalWhoosh;
		private audioMeleeSound _slowWhoosh;
		private audioMeleeSound _detailSound;
		private audioMeleeSound _handlingSound;
		private audioMeleeSound _equipSound;
		private audioMeleeSound _unequipSound;
		private audioMeleeSound _blockSound;
		private audioMeleeSound _parrySound;
		private CHandle<audioMeleeHitTypeMeleeSoundDictionary> _meleeSoundsByHitPerMaterialType;
		private audioMeleeRigTypeMeleeWeaponConfigurationMap _meleeWeaponConfigurationsByRigTypeMap;

		[Ordinal(1)] 
		[RED("fastWhoosh")] 
		public audioMeleeSound FastWhoosh
		{
			get
			{
				if (_fastWhoosh == null)
				{
					_fastWhoosh = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "fastWhoosh", cr2w, this);
				}
				return _fastWhoosh;
			}
			set
			{
				if (_fastWhoosh == value)
				{
					return;
				}
				_fastWhoosh = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("normalWhoosh")] 
		public audioMeleeSound NormalWhoosh
		{
			get
			{
				if (_normalWhoosh == null)
				{
					_normalWhoosh = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "normalWhoosh", cr2w, this);
				}
				return _normalWhoosh;
			}
			set
			{
				if (_normalWhoosh == value)
				{
					return;
				}
				_normalWhoosh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slowWhoosh")] 
		public audioMeleeSound SlowWhoosh
		{
			get
			{
				if (_slowWhoosh == null)
				{
					_slowWhoosh = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "slowWhoosh", cr2w, this);
				}
				return _slowWhoosh;
			}
			set
			{
				if (_slowWhoosh == value)
				{
					return;
				}
				_slowWhoosh = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("detailSound")] 
		public audioMeleeSound DetailSound
		{
			get
			{
				if (_detailSound == null)
				{
					_detailSound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "detailSound", cr2w, this);
				}
				return _detailSound;
			}
			set
			{
				if (_detailSound == value)
				{
					return;
				}
				_detailSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("handlingSound")] 
		public audioMeleeSound HandlingSound
		{
			get
			{
				if (_handlingSound == null)
				{
					_handlingSound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "handlingSound", cr2w, this);
				}
				return _handlingSound;
			}
			set
			{
				if (_handlingSound == value)
				{
					return;
				}
				_handlingSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("equipSound")] 
		public audioMeleeSound EquipSound
		{
			get
			{
				if (_equipSound == null)
				{
					_equipSound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "equipSound", cr2w, this);
				}
				return _equipSound;
			}
			set
			{
				if (_equipSound == value)
				{
					return;
				}
				_equipSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("unequipSound")] 
		public audioMeleeSound UnequipSound
		{
			get
			{
				if (_unequipSound == null)
				{
					_unequipSound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "unequipSound", cr2w, this);
				}
				return _unequipSound;
			}
			set
			{
				if (_unequipSound == value)
				{
					return;
				}
				_unequipSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("blockSound")] 
		public audioMeleeSound BlockSound
		{
			get
			{
				if (_blockSound == null)
				{
					_blockSound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "blockSound", cr2w, this);
				}
				return _blockSound;
			}
			set
			{
				if (_blockSound == value)
				{
					return;
				}
				_blockSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("parrySound")] 
		public audioMeleeSound ParrySound
		{
			get
			{
				if (_parrySound == null)
				{
					_parrySound = (audioMeleeSound) CR2WTypeManager.Create("audioMeleeSound", "parrySound", cr2w, this);
				}
				return _parrySound;
			}
			set
			{
				if (_parrySound == value)
				{
					return;
				}
				_parrySound = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("meleeSoundsByHitPerMaterialType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType
		{
			get
			{
				if (_meleeSoundsByHitPerMaterialType == null)
				{
					_meleeSoundsByHitPerMaterialType = (CHandle<audioMeleeHitTypeMeleeSoundDictionary>) CR2WTypeManager.Create("handle:audioMeleeHitTypeMeleeSoundDictionary", "meleeSoundsByHitPerMaterialType", cr2w, this);
				}
				return _meleeSoundsByHitPerMaterialType;
			}
			set
			{
				if (_meleeSoundsByHitPerMaterialType == value)
				{
					return;
				}
				_meleeSoundsByHitPerMaterialType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("meleeWeaponConfigurationsByRigTypeMap")] 
		public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap
		{
			get
			{
				if (_meleeWeaponConfigurationsByRigTypeMap == null)
				{
					_meleeWeaponConfigurationsByRigTypeMap = (audioMeleeRigTypeMeleeWeaponConfigurationMap) CR2WTypeManager.Create("audioMeleeRigTypeMeleeWeaponConfigurationMap", "meleeWeaponConfigurationsByRigTypeMap", cr2w, this);
				}
				return _meleeWeaponConfigurationsByRigTypeMap;
			}
			set
			{
				if (_meleeWeaponConfigurationsByRigTypeMap == value)
				{
					return;
				}
				_meleeWeaponConfigurationsByRigTypeMap = value;
				PropertySet(this);
			}
		}

		public audioMeleeWeaponConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
