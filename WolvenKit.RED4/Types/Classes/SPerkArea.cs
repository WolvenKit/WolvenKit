using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SPerkArea : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkArea> Type
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}

		[Ordinal(1)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("boughtPerks")] 
		public CArray<SPerk> BoughtPerks
		{
			get => GetPropertyValue<CArray<SPerk>>();
			set => SetPropertyValue<CArray<SPerk>>(value);
		}

		public SPerkArea()
		{
			BoughtPerks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
