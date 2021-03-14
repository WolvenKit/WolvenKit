using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		private SecurityLockerProperties _securityLockerProperties;
		private CBool _isStoringPlayerEquipement;

		[Ordinal(103)] 
		[RED("securityLockerProperties")] 
		public SecurityLockerProperties SecurityLockerProperties
		{
			get
			{
				if (_securityLockerProperties == null)
				{
					_securityLockerProperties = (SecurityLockerProperties) CR2WTypeManager.Create("SecurityLockerProperties", "securityLockerProperties", cr2w, this);
				}
				return _securityLockerProperties;
			}
			set
			{
				if (_securityLockerProperties == value)
				{
					return;
				}
				_securityLockerProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("isStoringPlayerEquipement")] 
		public CBool IsStoringPlayerEquipement
		{
			get
			{
				if (_isStoringPlayerEquipement == null)
				{
					_isStoringPlayerEquipement = (CBool) CR2WTypeManager.Create("Bool", "isStoringPlayerEquipement", cr2w, this);
				}
				return _isStoringPlayerEquipement;
			}
			set
			{
				if (_isStoringPlayerEquipement == value)
				{
					return;
				}
				_isStoringPlayerEquipement = value;
				PropertySet(this);
			}
		}

		public SecurityLockerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
