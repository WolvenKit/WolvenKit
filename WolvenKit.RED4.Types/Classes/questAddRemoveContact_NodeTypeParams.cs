using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAddRemoveContact_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("contact")] 
		public CName Contact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("addContact")] 
		public CBool AddContact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questAddRemoveContact_NodeTypeParams()
		{
			AddContact = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
