using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerBountySystem : ScannerChunk
	{
		private BountyUI _bounty;

		[Ordinal(0)] 
		[RED("bounty")] 
		public BountyUI Bounty
		{
			get => GetProperty(ref _bounty);
			set => SetProperty(ref _bounty, value);
		}

		public ScannerBountySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
