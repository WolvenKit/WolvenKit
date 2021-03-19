using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiVOWithDelay : CVariable
	{
		private CFloat _playDelay;
		private CString _voHexID;

		[Ordinal(0)] 
		[RED("playDelay")] 
		public CFloat PlayDelay
		{
			get => GetProperty(ref _playDelay);
			set => SetProperty(ref _playDelay, value);
		}

		[Ordinal(1)] 
		[RED("voHexID")] 
		public CString VoHexID
		{
			get => GetProperty(ref _voHexID);
			set => SetProperty(ref _voHexID, value);
		}

		public gameuiVOWithDelay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
