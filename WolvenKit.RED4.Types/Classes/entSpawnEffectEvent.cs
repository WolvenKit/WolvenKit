using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSpawnEffectEvent : redEvent
	{
		private CHandle<worldEffectBlackboard> _blackboard;
		private CName _effectName;
		private CRUID _idForRandomizedEffect;
		private CName _effectInstanceName;
		private CBool _persistOnDetach;
		private CBool _breakAllLoops;
		private CBool _breakAllOnDestroy;
		private CUInt32 _e3hackDeferCount;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<worldEffectBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(2)] 
		[RED("idForRandomizedEffect")] 
		public CRUID IdForRandomizedEffect
		{
			get => GetProperty(ref _idForRandomizedEffect);
			set => SetProperty(ref _idForRandomizedEffect, value);
		}

		[Ordinal(3)] 
		[RED("effectInstanceName")] 
		public CName EffectInstanceName
		{
			get => GetProperty(ref _effectInstanceName);
			set => SetProperty(ref _effectInstanceName, value);
		}

		[Ordinal(4)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get => GetProperty(ref _persistOnDetach);
			set => SetProperty(ref _persistOnDetach, value);
		}

		[Ordinal(5)] 
		[RED("breakAllLoops")] 
		public CBool BreakAllLoops
		{
			get => GetProperty(ref _breakAllLoops);
			set => SetProperty(ref _breakAllLoops, value);
		}

		[Ordinal(6)] 
		[RED("breakAllOnDestroy")] 
		public CBool BreakAllOnDestroy
		{
			get => GetProperty(ref _breakAllOnDestroy);
			set => SetProperty(ref _breakAllOnDestroy, value);
		}

		[Ordinal(7)] 
		[RED("e3hackDeferCount")] 
		public CUInt32 E3hackDeferCount
		{
			get => GetProperty(ref _e3hackDeferCount);
			set => SetProperty(ref _e3hackDeferCount, value);
		}
	}
}
