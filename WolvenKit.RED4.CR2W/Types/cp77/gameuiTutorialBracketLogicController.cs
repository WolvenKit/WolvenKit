using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		private CHandle<inkanimProxy> _loopAnim;

		[Ordinal(1)] 
		[RED("loopAnim")] 
		public CHandle<inkanimProxy> LoopAnim
		{
			get => GetProperty(ref _loopAnim);
			set => SetProperty(ref _loopAnim, value);
		}

		public gameuiTutorialBracketLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
