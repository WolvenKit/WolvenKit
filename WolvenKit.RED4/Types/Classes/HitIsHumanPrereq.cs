using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIsHumanPrereq : GenericHitPrereq
	{
		[Ordinal(8)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HitIsHumanPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
