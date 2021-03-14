using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithStatPoolEffector : ModifyDamageEffector
	{
		private CEnum<gamedataStatPoolType> _statPool;
		private CString _poolStatus;
		private CFloat _maxDmg;
		private CString _refObj;

		[Ordinal(2)] 
		[RED("statPool")] 
		public CEnum<gamedataStatPoolType> StatPool
		{
			get
			{
				if (_statPool == null)
				{
					_statPool = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPool", cr2w, this);
				}
				return _statPool;
			}
			set
			{
				if (_statPool == value)
				{
					return;
				}
				_statPool = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("poolStatus")] 
		public CString PoolStatus
		{
			get
			{
				if (_poolStatus == null)
				{
					_poolStatus = (CString) CR2WTypeManager.Create("String", "poolStatus", cr2w, this);
				}
				return _poolStatus;
			}
			set
			{
				if (_poolStatus == value)
				{
					return;
				}
				_poolStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxDmg")] 
		public CFloat MaxDmg
		{
			get
			{
				if (_maxDmg == null)
				{
					_maxDmg = (CFloat) CR2WTypeManager.Create("Float", "maxDmg", cr2w, this);
				}
				return _maxDmg;
			}
			set
			{
				if (_maxDmg == value)
				{
					return;
				}
				_maxDmg = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("refObj")] 
		public CString RefObj
		{
			get
			{
				if (_refObj == null)
				{
					_refObj = (CString) CR2WTypeManager.Create("String", "refObj", cr2w, this);
				}
				return _refObj;
			}
			set
			{
				if (_refObj == value)
				{
					return;
				}
				_refObj = value;
				PropertySet(this);
			}
		}

		public ModifyDamageWithStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
