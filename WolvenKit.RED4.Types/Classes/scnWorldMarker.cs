using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWorldMarker : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnWorldMarkerType> Type
		{
			get => GetPropertyValue<CEnum<scnWorldMarkerType>>();
			set => SetPropertyValue<CEnum<scnWorldMarkerType>>(value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
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

		public scnWorldMarker()
		{
			Type = Enums.scnWorldMarkerType.NodeRef;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
