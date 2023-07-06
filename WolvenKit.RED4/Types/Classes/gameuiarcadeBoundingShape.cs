using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiarcadeBoundingShape : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boundingShape")] 
		public inkWidgetReference BoundingShape
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeBoundingShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
