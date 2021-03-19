using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentPS : gameComponentPS
	{
		private CArray<gameStatusEffect> _statusEffectArray;
		private CHandle<gameDelayedFunctionsScheduler> _delayedFunctions;
		private CHandle<gameDelayedFunctionsScheduler> _delayedFunctionsNoTd;
		private CBool _isPlayerControlled;
		private CBool _tickComponent;

		[Ordinal(0)] 
		[RED("statusEffectArray")] 
		public CArray<gameStatusEffect> StatusEffectArray
		{
			get => GetProperty(ref _statusEffectArray);
			set => SetProperty(ref _statusEffectArray, value);
		}

		[Ordinal(1)] 
		[RED("delayedFunctions")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctions
		{
			get => GetProperty(ref _delayedFunctions);
			set => SetProperty(ref _delayedFunctions, value);
		}

		[Ordinal(2)] 
		[RED("delayedFunctionsNoTd")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctionsNoTd
		{
			get => GetProperty(ref _delayedFunctionsNoTd);
			set => SetProperty(ref _delayedFunctionsNoTd, value);
		}

		[Ordinal(3)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get => GetProperty(ref _isPlayerControlled);
			set => SetProperty(ref _isPlayerControlled, value);
		}

		[Ordinal(4)] 
		[RED("tickComponent")] 
		public CBool TickComponent
		{
			get => GetProperty(ref _tickComponent);
			set => SetProperty(ref _tickComponent, value);
		}

		public gameStatusEffectComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
