using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedLookAtAdd : entReplicatedLookAtData
	{
		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetPropertyValue<animLookAtRequest>();
			set => SetPropertyValue<animLookAtRequest>(value);
		}

		[Ordinal(3)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetPropertyValue<CHandle<entIPositionProvider>>();
			set => SetPropertyValue<CHandle<entIPositionProvider>>(value);
		}

		[Ordinal(4)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get => GetPropertyValue<animLookAtRef>();
			set => SetPropertyValue<animLookAtRef>(value);
		}

		public entReplicatedLookAtAdd()
		{
			BodyPart = "Eyes";
			Request = new animLookAtRequest();
			Ref = new animLookAtRef();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
