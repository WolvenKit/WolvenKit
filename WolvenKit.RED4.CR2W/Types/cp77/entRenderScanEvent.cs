using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderScanEvent : redEvent
	{
		private CEnum<rendPostFx_ScanningState> _scanState;

		[Ordinal(0)] 
		[RED("scanState")] 
		public CEnum<rendPostFx_ScanningState> ScanState
		{
			get => GetProperty(ref _scanState);
			set => SetProperty(ref _scanState, value);
		}

		public entRenderScanEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
