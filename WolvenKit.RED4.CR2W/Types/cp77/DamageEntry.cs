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
			get => GetProperty(ref _damageInfo);
			set => SetProperty(ref _damageInfo, value);
		}

		[Ordinal(1)] 
		[RED("damageOverTimeInfo")] 
		public gameuiDamageInfo DamageOverTimeInfo
		{
			get => GetProperty(ref _damageOverTimeInfo);
			set => SetProperty(ref _damageOverTimeInfo, value);
		}

		[Ordinal(2)] 
		[RED("hasDamageInfo")] 
		public CBool HasDamageInfo
		{
			get => GetProperty(ref _hasDamageInfo);
			set => SetProperty(ref _hasDamageInfo, value);
		}

		[Ordinal(3)] 
		[RED("hasDamageOverTimeInfo")] 
		public CBool HasDamageOverTimeInfo
		{
			get => GetProperty(ref _hasDamageOverTimeInfo);
			set => SetProperty(ref _hasDamageOverTimeInfo, value);
		}

		[Ordinal(4)] 
		[RED("oneInstance")] 
		public CBool OneInstance
		{
			get => GetProperty(ref _oneInstance);
			set => SetProperty(ref _oneInstance, value);
		}

		[Ordinal(5)] 
		[RED("oneDotInstance")] 
		public CBool OneDotInstance
		{
			get => GetProperty(ref _oneDotInstance);
			set => SetProperty(ref _oneDotInstance, value);
		}

		[Ordinal(6)] 
		[RED("hasDotAccumulator")] 
		public CBool HasDotAccumulator
		{
			get => GetProperty(ref _hasDotAccumulator);
			set => SetProperty(ref _hasDotAccumulator, value);
		}

		public DamageEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
