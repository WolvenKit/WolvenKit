using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocPerkHoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("Area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(2)] 
		[RED("Type")] 
		public CEnum<gamedataNewPerkType> Type
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(3)] 
		[RED("AttributeID")] 
		public TweakDBID AttributeID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public RipperdocPerkHoverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
