using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BillboardDevice : InteractiveDevice
	{
		private CHandle<entIComponent> _advUiComponent;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(97)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get => GetProperty(ref _advUiComponent);
			set => SetProperty(ref _advUiComponent, value);
		}

		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		public BillboardDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
