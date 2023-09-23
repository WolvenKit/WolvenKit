using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectableItemObject : gameItemObject
	{
		[Ordinal(40)] 
		[RED("inspectableClues")] 
		public CArray<SInspectableClue> InspectableClues
		{
			get => GetPropertyValue<CArray<SInspectableClue>>();
			set => SetPropertyValue<CArray<SInspectableClue>>(value);
		}

		public InspectableItemObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
