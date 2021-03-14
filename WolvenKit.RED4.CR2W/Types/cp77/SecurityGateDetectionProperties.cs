using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateDetectionProperties : CVariable
	{
		private CBool _performWeaponCheck;
		private CBool _performCyberwareCheck;
		private CEnum<ESecurityGateEntranceType> _scannerEntranceType;
		private CBool _performCheckOnPlayerOnly;

		[Ordinal(0)] 
		[RED("performWeaponCheck")] 
		public CBool PerformWeaponCheck
		{
			get
			{
				if (_performWeaponCheck == null)
				{
					_performWeaponCheck = (CBool) CR2WTypeManager.Create("Bool", "performWeaponCheck", cr2w, this);
				}
				return _performWeaponCheck;
			}
			set
			{
				if (_performWeaponCheck == value)
				{
					return;
				}
				_performWeaponCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("performCyberwareCheck")] 
		public CBool PerformCyberwareCheck
		{
			get
			{
				if (_performCyberwareCheck == null)
				{
					_performCyberwareCheck = (CBool) CR2WTypeManager.Create("Bool", "performCyberwareCheck", cr2w, this);
				}
				return _performCyberwareCheck;
			}
			set
			{
				if (_performCyberwareCheck == value)
				{
					return;
				}
				_performCyberwareCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scannerEntranceType")] 
		public CEnum<ESecurityGateEntranceType> ScannerEntranceType
		{
			get
			{
				if (_scannerEntranceType == null)
				{
					_scannerEntranceType = (CEnum<ESecurityGateEntranceType>) CR2WTypeManager.Create("ESecurityGateEntranceType", "scannerEntranceType", cr2w, this);
				}
				return _scannerEntranceType;
			}
			set
			{
				if (_scannerEntranceType == value)
				{
					return;
				}
				_scannerEntranceType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("performCheckOnPlayerOnly")] 
		public CBool PerformCheckOnPlayerOnly
		{
			get
			{
				if (_performCheckOnPlayerOnly == null)
				{
					_performCheckOnPlayerOnly = (CBool) CR2WTypeManager.Create("Bool", "performCheckOnPlayerOnly", cr2w, this);
				}
				return _performCheckOnPlayerOnly;
			}
			set
			{
				if (_performCheckOnPlayerOnly == value)
				{
					return;
				}
				_performCheckOnPlayerOnly = value;
				PropertySet(this);
			}
		}

		public SecurityGateDetectionProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
