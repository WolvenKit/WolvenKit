using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CanSellNewPerkResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public CanSellNewPerkResult()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
