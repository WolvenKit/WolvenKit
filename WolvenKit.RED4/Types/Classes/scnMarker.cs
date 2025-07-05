using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnMarker : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnMarkerType> Type
		{
			get => GetPropertyValue<CEnum<scnMarkerType>>();
			set => SetPropertyValue<CEnum<scnMarkerType>>(value);
		}

		[Ordinal(1)] 
		[RED("localMarkerId")] 
		public CName LocalMarkerId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnMarker()
		{
			Type = Enums.scnMarkerType.Global;
			EntityRef = new gameEntityReference { Names = new() };
			IsMounted = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
