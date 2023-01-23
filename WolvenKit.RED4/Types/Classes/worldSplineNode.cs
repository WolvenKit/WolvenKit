using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSplineNode : worldSocketNode
	{
		[Ordinal(4)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get => GetPropertyValue<CHandle<Spline>>();
			set => SetPropertyValue<CHandle<Spline>>(value);
		}

		[Ordinal(5)] 
		[RED("destSnapedNode")] 
		public NodeRef DestSnapedNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("destSnapedSocketName")] 
		public CName DestSnapedSocketName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("entrySnapedNode")] 
		public NodeRef EntrySnapedNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("entrySnapedSocketName")] 
		public CName EntrySnapedSocketName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldSplineNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
