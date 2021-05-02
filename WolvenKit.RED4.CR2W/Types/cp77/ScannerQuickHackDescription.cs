using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuickHackDescription : ScannerChunk
	{
		private CHandle<QuickhackData> _quickHackDescription;

		[Ordinal(0)] 
		[RED("QuickHackDescription")] 
		public CHandle<QuickhackData> QuickHackDescription
		{
			get => GetProperty(ref _quickHackDescription);
			set => SetProperty(ref _quickHackDescription, value);
		}

		public ScannerQuickHackDescription(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
