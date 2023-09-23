using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkDisplayData : BasePerkDisplayData
	{
		[Ordinal(10)] 
		[RED("area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataNewPerkType> Type
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(12)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerkDisplayData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
