using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetInspectMode_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("startingOffset")] 
		public CFloat StartingOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("zoomOffset")] 
		public CFloat ZoomOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questSetInspectMode_NodeType()
		{
			StartingOffset = 0.500000F;
			ZoomOffset = 0.500000F;
			TimeInterval = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
