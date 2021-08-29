using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveStatusEffectEvent : redEvent
	{
		private TweakDBID _effectID;
		private CUInt32 _removeCount;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetProperty(ref _effectID);
			set => SetProperty(ref _effectID, value);
		}

		[Ordinal(1)] 
		[RED("removeCount")] 
		public CUInt32 RemoveCount
		{
			get => GetProperty(ref _removeCount);
			set => SetProperty(ref _removeCount, value);
		}
	}
}
