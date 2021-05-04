using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UndressPlayer : redEvent
	{
		private CBool _isCensored;

		[Ordinal(0)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetProperty(ref _isCensored);
			set => SetProperty(ref _isCensored, value);
		}

		public UndressPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
