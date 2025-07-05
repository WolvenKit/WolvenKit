using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVideoSequenceController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("videoSequence")] 
		public CArray<inkVideoSequenceEntry> VideoSequence
		{
			get => GetPropertyValue<CArray<inkVideoSequenceEntry>>();
			set => SetPropertyValue<CArray<inkVideoSequenceEntry>>(value);
		}

		public inkVideoSequenceController()
		{
			VideoWidget = new inkVideoWidgetReference();
			VideoSequence = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
