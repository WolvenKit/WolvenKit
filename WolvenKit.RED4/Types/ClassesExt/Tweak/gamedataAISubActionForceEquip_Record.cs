
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionForceEquip_Record
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
		
		[RED("equipDespiteInterruption")]
		[REDProperty(IsIgnored = true)]
		public CBool EquipDespiteInterruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("itemCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemObject")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemObject
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemTag")]
		[REDProperty(IsIgnored = true)]
		public CName ItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
