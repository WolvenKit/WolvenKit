using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectPlacedSpawner : effectSpawner
	{
		private CHandle<effectIPlacementEntries> _placement;

		[Ordinal(0)] 
		[RED("placement")] 
		public CHandle<effectIPlacementEntries> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		public effectPlacedSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
