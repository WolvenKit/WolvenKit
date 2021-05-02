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
			get => GetProperty(ref _statPool);
			set => SetProperty(ref _statPool, value);
		}

		[Ordinal(3)] 
		[RED("poolStatus")] 
		public CString PoolStatus
		{
			get => GetProperty(ref _poolStatus);
			set => SetProperty(ref _poolStatus, value);
		}

		[Ordinal(4)] 
		[RED("maxDmg")] 
		public CFloat MaxDmg
		{
			get => GetProperty(ref _maxDmg);
			set => SetProperty(ref _maxDmg, value);
		}

		[Ordinal(5)] 
		[RED("refObj")] 
		public CString RefObj
		{
			get => GetProperty(ref _refObj);
			set => SetProperty(ref _refObj, value);
		}

		public ModifyDamageWithStatPoolEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
