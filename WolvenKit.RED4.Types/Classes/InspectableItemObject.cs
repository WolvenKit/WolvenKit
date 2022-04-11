using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InspectableItemObject : gameItemObject
	{
		[Ordinal(38)] 
		[RED("inspectableClues")] 
		public CArray<SInspectableClue> InspectableClues
		{
			get => GetPropertyValue<CArray<SInspectableClue>>();
			set => SetPropertyValue<CArray<SInspectableClue>>(value);
		}

		public InspectableItemObject()
		{
			InspectableClues = new();
		}
	}
}
