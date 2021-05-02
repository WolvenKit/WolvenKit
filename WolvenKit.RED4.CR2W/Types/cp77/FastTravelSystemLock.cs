using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystemLock : CVariable
	{
		private CName _lockReason;
		private TweakDBID _linkedStatusEffectID;

		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get => GetProperty(ref _lockReason);
			set => SetProperty(ref _lockReason, value);
		}

		[Ordinal(1)] 
		[RED("linkedStatusEffectID")] 
		public TweakDBID LinkedStatusEffectID
		{
			get => GetProperty(ref _linkedStatusEffectID);
			set => SetProperty(ref _linkedStatusEffectID, value);
		}

		public FastTravelSystemLock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
