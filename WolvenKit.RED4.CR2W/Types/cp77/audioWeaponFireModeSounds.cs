using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponFireModeSounds : CVariable
	{
		private CName _burst;
		private CName _charge;
		private CName _fullAuto;
		private CName _semiAuto;
		private CName _windup;

		[Ordinal(0)] 
		[RED("burst")] 
		public CName Burst
		{
			get
			{
				if (_burst == null)
				{
					_burst = (CName) CR2WTypeManager.Create("CName", "burst", cr2w, this);
				}
				return _burst;
			}
			set
			{
				if (_burst == value)
				{
					return;
				}
				_burst = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("charge")] 
		public CName Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (CName) CR2WTypeManager.Create("CName", "charge", cr2w, this);
				}
				return _charge;
			}
			set
			{
				if (_charge == value)
				{
					return;
				}
				_charge = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fullAuto")] 
		public CName FullAuto
		{
			get
			{
				if (_fullAuto == null)
				{
					_fullAuto = (CName) CR2WTypeManager.Create("CName", "fullAuto", cr2w, this);
				}
				return _fullAuto;
			}
			set
			{
				if (_fullAuto == value)
				{
					return;
				}
				_fullAuto = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("semiAuto")] 
		public CName SemiAuto
		{
			get
			{
				if (_semiAuto == null)
				{
					_semiAuto = (CName) CR2WTypeManager.Create("CName", "semiAuto", cr2w, this);
				}
				return _semiAuto;
			}
			set
			{
				if (_semiAuto == value)
				{
					return;
				}
				_semiAuto = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("windup")] 
		public CName Windup
		{
			get
			{
				if (_windup == null)
				{
					_windup = (CName) CR2WTypeManager.Create("CName", "windup", cr2w, this);
				}
				return _windup;
			}
			set
			{
				if (_windup == value)
				{
					return;
				}
				_windup = value;
				PropertySet(this);
			}
		}

		public audioWeaponFireModeSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
