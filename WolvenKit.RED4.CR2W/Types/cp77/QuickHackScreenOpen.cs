using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackScreenOpen : redEvent
	{
		private CBool _setToOpen;

		[Ordinal(0)] 
		[RED("setToOpen")] 
		public CBool SetToOpen
		{
			get => GetProperty(ref _setToOpen);
			set => SetProperty(ref _setToOpen, value);
		}

		public QuickHackScreenOpen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
