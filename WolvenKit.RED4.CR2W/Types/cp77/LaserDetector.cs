using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LaserDetector : ProximityDetector
	{
		private CArrayFixedSize<CHandle<entMeshComponent>> _lasers;

		[Ordinal(92)] 
		[RED("lasers", 2)] 
		public CArrayFixedSize<CHandle<entMeshComponent>> Lasers
		{
			get => GetProperty(ref _lasers);
			set => SetProperty(ref _lasers, value);
		}

		public LaserDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
