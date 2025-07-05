using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SPerk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		[Ordinal(1)] 
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SPerk()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
