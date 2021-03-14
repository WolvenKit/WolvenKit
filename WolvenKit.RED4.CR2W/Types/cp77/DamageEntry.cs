using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageEntry : CVariable
	{
		private gameuiDamageInfo _damageInfo;
		private gameuiDamageInfo _damageOverTimeInfo;
		private CBool _hasDamageInfo;
		private CBool _hasDamageOverTimeInfo;
		private CBool _oneInstance;
		private CBool _oneDotInstance;
		private CBool _hasDotAccumulator;

		[Ordinal(0)] 
		[RED("damageInfo")] 
		public gameuiDamageInfo DamageInfo
		{
			get
			{
				if (_damageInfo == null)
				{
					_damageInfo = (gameuiDamageInfo) CR2WTypeManager.Create("gameuiDamageInfo", "damageInfo", cr2w, this);
				}
				return _damageInfo;
			}
			set
			{
				if (_damageInfo == value)
				{
					return;
				}
				_damageInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("damageOverTimeInfo")] 
		public gameuiDamageInfo DamageOverTimeInfo
		{
			get
			{
				if (_damageOverTimeInfo == null)
				{
					_damageOverTimeInfo = (gameuiDamageInfo) CR2WTypeManager.Create("gameuiDamageInfo", "damageOverTimeInfo", cr2w, this);
				}
				return _damageOverTimeInfo;
			}
			set
			{
				if (_damageOverTimeInfo == value)
				{
					return;
				}
				_damageOverTimeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasDamageInfo")] 
		public CBool HasDamageInfo
		{
			get
			{
				if (_hasDamageInfo == null)
				{
					_hasDamageInfo = (CBool) CR2WTypeManager.Create("Bool", "hasDamageInfo", cr2w, this);
				}
				return _hasDamageInfo;
			}
			set
			{
				if (_hasDamageInfo == value)
				{
					return;
				}
				_hasDamageInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasDamageOverTimeInfo")] 
		public CBool HasDamageOverTimeInfo
		{
			get
			{
				if (_hasDamageOverTimeInfo == null)
				{
					_hasDamageOverTimeInfo = (CBool) CR2WTypeManager.Create("Bool", "hasDamageOverTimeInfo", cr2w, this);
				}
				return _hasDamageOverTimeInfo;
			}
			set
			{
				if (_hasDamageOverTimeInfo == value)
				{
					return;
				}
				_hasDamageOverTimeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("oneInstance")] 
		public CBool OneInstance
		{
			get
			{
				if (_oneInstance == null)
				{
					_oneInstance = (CBool) CR2WTypeManager.Create("Bool", "oneInstance", cr2w, this);
				}
				return _oneInstance;
			}
			set
			{
				if (_oneInstance == value)
				{
					return;
				}
				_oneInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("oneDotInstance")] 
		public CBool OneDotInstance
		{
			get
			{
				if (_oneDotInstance == null)
				{
					_oneDotInstance = (CBool) CR2WTypeManager.Create("Bool", "oneDotInstance", cr2w, this);
				}
				return _oneDotInstance;
			}
			set
			{
				if (_oneDotInstance == value)
				{
					return;
				}
				_oneDotInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hasDotAccumulator")] 
		public CBool HasDotAccumulator
		{
			get
			{
				if (_hasDotAccumulator == null)
				{
					_hasDotAccumulator = (CBool) CR2WTypeManager.Create("Bool", "hasDotAccumulator", cr2w, this);
				}
				return _hasDotAccumulator;
			}
			set
			{
				if (_hasDotAccumulator == value)
				{
					return;
				}
				_hasDotAccumulator = value;
				PropertySet(this);
			}
		}

		public DamageEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
