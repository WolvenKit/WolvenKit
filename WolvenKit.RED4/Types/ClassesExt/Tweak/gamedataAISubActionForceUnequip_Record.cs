
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionForceUnequip_Record
	{
		[RED("animationTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attachmentSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttachmentSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropItem")]
		[REDProperty(IsIgnored = true)]
		public CBool DropItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("generateLootAfterDrop")]
		[REDProperty(IsIgnored = true)]
		public CBool GenerateLootAfterDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("unequipDespiteInterruption")]
		[REDProperty(IsIgnored = true)]
		public CBool UnequipDespiteInterruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
