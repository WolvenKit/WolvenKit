using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Intercom : InteractiveDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CName _distractionSound;

		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(99)] 
		[RED("distractionSound")] 
		public CName DistractionSound
		{
			get => GetProperty(ref _distractionSound);
			set => SetProperty(ref _distractionSound, value);
		}

		public Intercom(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
