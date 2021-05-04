using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackEvent : redEvent
	{
		private CBool _wasQuickHacked;
		private CName _quickHackName;

		[Ordinal(0)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetProperty(ref _wasQuickHacked);
			set => SetProperty(ref _wasQuickHacked, value);
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CName QuickHackName
		{
			get => GetProperty(ref _quickHackName);
			set => SetProperty(ref _quickHackName, value);
		}

		public SetQuickHackEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
