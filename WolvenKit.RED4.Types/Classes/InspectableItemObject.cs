using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InspectableItemObject : gameItemObject
	{
		private CArray<SInspectableClue> _inspectableClues;

		[Ordinal(43)] 
		[RED("inspectableClues")] 
		public CArray<SInspectableClue> InspectableClues
		{
			get => GetProperty(ref _inspectableClues);
			set => SetProperty(ref _inspectableClues, value);
		}
	}
}
