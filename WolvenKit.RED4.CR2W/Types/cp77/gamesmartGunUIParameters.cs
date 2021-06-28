using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUIParameters : IScriptable
	{
		private CArray<gamesmartGunUITargetParameters> _targets;
		private gamesmartGunUISightParameters _sight;
		private Vector2 _crosshairPos;
		private CBool _hasRequiredCyberware;
		private CFloat _timeToRemoveOccludedTarget;
		private CFloat _timeToLock;
		private CFloat _timeToUnlock;

		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<gamesmartGunUITargetParameters> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(1)] 
		[RED("sight")] 
		public gamesmartGunUISightParameters Sight
		{
			get => GetProperty(ref _sight);
			set => SetProperty(ref _sight, value);
		}

		[Ordinal(2)] 
		[RED("crosshairPos")] 
		public Vector2 CrosshairPos
		{
			get => GetProperty(ref _crosshairPos);
			set => SetProperty(ref _crosshairPos, value);
		}

		[Ordinal(3)] 
		[RED("hasRequiredCyberware")] 
		public CBool HasRequiredCyberware
		{
			get => GetProperty(ref _hasRequiredCyberware);
			set => SetProperty(ref _hasRequiredCyberware, value);
		}

		[Ordinal(4)] 
		[RED("timeToRemoveOccludedTarget")] 
		public CFloat TimeToRemoveOccludedTarget
		{
			get => GetProperty(ref _timeToRemoveOccludedTarget);
			set => SetProperty(ref _timeToRemoveOccludedTarget, value);
		}

		[Ordinal(5)] 
		[RED("timeToLock")] 
		public CFloat TimeToLock
		{
			get => GetProperty(ref _timeToLock);
			set => SetProperty(ref _timeToLock, value);
		}

		[Ordinal(6)] 
		[RED("timeToUnlock")] 
		public CFloat TimeToUnlock
		{
			get => GetProperty(ref _timeToUnlock);
			set => SetProperty(ref _timeToUnlock, value);
		}

		public gamesmartGunUIParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
