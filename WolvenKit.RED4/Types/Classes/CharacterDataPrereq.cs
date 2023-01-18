using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterDataPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("idToCheck")] 
		public TweakDBID IdToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CharacterDataPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
