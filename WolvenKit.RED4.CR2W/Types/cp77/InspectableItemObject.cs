using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableItemObject : gameItemObject
	{
		private CArray<SInspectableClue> _inspectableClues;

		[Ordinal(43)] 
		[RED("inspectableClues")] 
		public CArray<SInspectableClue> InspectableClues
		{
			get => GetProperty(ref _inspectableClues);
			set => SetProperty(ref _inspectableClues, value);
		}

		public InspectableItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
