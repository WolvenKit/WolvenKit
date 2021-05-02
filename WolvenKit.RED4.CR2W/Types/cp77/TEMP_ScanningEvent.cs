using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TEMP_ScanningEvent : redEvent
	{
		private CName _clue;
		private CBool _showUI;

		[Ordinal(0)] 
		[RED("clue")] 
		public CName Clue
		{
			get => GetProperty(ref _clue);
			set => SetProperty(ref _clue, value);
		}

		[Ordinal(1)] 
		[RED("showUI")] 
		public CBool ShowUI
		{
			get => GetProperty(ref _showUI);
			set => SetProperty(ref _showUI, value);
		}

		public TEMP_ScanningEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
