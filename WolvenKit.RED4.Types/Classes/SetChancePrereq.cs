using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetChancePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("setChance")] 
		public CFloat SetChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetChancePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
