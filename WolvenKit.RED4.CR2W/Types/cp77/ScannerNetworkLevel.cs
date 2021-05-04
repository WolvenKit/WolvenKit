using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNetworkLevel : ScannerChunk
	{
		private CInt32 _networkLevel;

		[Ordinal(0)] 
		[RED("networkLevel")] 
		public CInt32 NetworkLevel
		{
			get => GetProperty(ref _networkLevel);
			set => SetProperty(ref _networkLevel, value);
		}

		public ScannerNetworkLevel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
