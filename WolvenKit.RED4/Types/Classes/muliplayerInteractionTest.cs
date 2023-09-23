using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class muliplayerInteractionTest : gameObject
	{
		[Ordinal(36)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public muliplayerInteractionTest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
