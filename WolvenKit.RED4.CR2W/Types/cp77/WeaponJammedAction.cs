using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponJammedAction : StatusEffectActions
	{
		private CFloat _jammedWeaponDuration;
		private CFloat _jammedWeaponStartTimeStamp;

		[Ordinal(0)] 
		[RED("jammedWeaponDuration")] 
		public CFloat JammedWeaponDuration
		{
			get
			{
				if (_jammedWeaponDuration == null)
				{
					_jammedWeaponDuration = (CFloat) CR2WTypeManager.Create("Float", "jammedWeaponDuration", cr2w, this);
				}
				return _jammedWeaponDuration;
			}
			set
			{
				if (_jammedWeaponDuration == value)
				{
					return;
				}
				_jammedWeaponDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("jammedWeaponStartTimeStamp")] 
		public CFloat JammedWeaponStartTimeStamp
		{
			get
			{
				if (_jammedWeaponStartTimeStamp == null)
				{
					_jammedWeaponStartTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "jammedWeaponStartTimeStamp", cr2w, this);
				}
				return _jammedWeaponStartTimeStamp;
			}
			set
			{
				if (_jammedWeaponStartTimeStamp == value)
				{
					return;
				}
				_jammedWeaponStartTimeStamp = value;
				PropertySet(this);
			}
		}

		public WeaponJammedAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
