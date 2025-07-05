using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RarityOfEquippedCyberdeckPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("minimumQuality")] 
		public CInt32 MinimumQuality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RarityOfEquippedCyberdeckPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
