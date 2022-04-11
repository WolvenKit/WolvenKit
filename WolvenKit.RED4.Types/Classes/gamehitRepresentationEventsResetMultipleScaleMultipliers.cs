using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamehitRepresentationEventsResetMultipleScaleMultipliers : redEvent
	{
		[Ordinal(0)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gamehitRepresentationEventsResetMultipleScaleMultipliers()
		{
			ShapeNames = new();
		}
	}
}
