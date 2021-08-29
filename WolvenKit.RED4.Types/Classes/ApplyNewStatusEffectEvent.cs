using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyNewStatusEffectEvent : redEvent
	{
		private TweakDBID _effectID;
		private TweakDBID _instigatorID;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetProperty(ref _effectID);
			set => SetProperty(ref _effectID, value);
		}

		[Ordinal(1)] 
		[RED("instigatorID")] 
		public TweakDBID InstigatorID
		{
			get => GetProperty(ref _instigatorID);
			set => SetProperty(ref _instigatorID, value);
		}
	}
}
