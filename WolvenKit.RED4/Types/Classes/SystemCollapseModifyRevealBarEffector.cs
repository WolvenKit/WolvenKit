using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SystemCollapseModifyRevealBarEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SystemCollapseModifyRevealBarEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
