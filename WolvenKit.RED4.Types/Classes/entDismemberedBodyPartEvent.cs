using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDismemberedBodyPartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bones", 32)] 
		public CStatic<CName> Bones
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		public entDismemberedBodyPartEvent()
		{
			Bones = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
