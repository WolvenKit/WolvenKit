using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanEvent : redEvent
	{
		private CString _clue;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("clue")] 
		public CString Clue
		{
			get => GetProperty(ref _clue);
			set => SetProperty(ref _clue, value);
		}

		[Ordinal(1)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		public ScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
