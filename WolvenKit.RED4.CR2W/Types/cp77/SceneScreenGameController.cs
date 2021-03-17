using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneScreenGameController : gameuiWidgetGameController
	{
		private CUInt32 _onQuestAnimChangeListener;

		[Ordinal(2)] 
		[RED("onQuestAnimChangeListener")] 
		public CUInt32 OnQuestAnimChangeListener
		{
			get => GetProperty(ref _onQuestAnimChangeListener);
			set => SetProperty(ref _onQuestAnimChangeListener, value);
		}

		public SceneScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
