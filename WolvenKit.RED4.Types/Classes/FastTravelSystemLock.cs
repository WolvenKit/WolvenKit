using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelSystemLock : RedBaseClass
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
	}
}
