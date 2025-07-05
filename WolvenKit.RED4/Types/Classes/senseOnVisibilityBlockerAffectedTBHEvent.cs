using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseOnVisibilityBlockerAffectedTBHEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newTBHModifier")] 
		public CFloat NewTBHModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public senseOnVisibilityBlockerAffectedTBHEvent()
		{
			NewTBHModifier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
