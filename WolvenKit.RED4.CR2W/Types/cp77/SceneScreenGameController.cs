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
			get
			{
				if (_onQuestAnimChangeListener == null)
				{
					_onQuestAnimChangeListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onQuestAnimChangeListener", cr2w, this);
				}
				return _onQuestAnimChangeListener;
			}
			set
			{
				if (_onQuestAnimChangeListener == value)
				{
					return;
				}
				_onQuestAnimChangeListener = value;
				PropertySet(this);
			}
		}

		public SceneScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
