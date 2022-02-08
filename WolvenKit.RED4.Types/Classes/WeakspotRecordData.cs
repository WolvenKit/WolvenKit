using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakspotRecordData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isInvulnerable")] 
		public CBool IsInvulnerable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("reducedMeleeDamage")] 
		public CBool ReducedMeleeDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
