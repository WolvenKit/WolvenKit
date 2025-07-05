using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitFlagPrereq : GenericHitPrereq
	{
		[Ordinal(8)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}

		public HitFlagPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
