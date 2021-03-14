using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneScreen : gameObject
	{
		private CHandle<SceneScreenUIAnimationsData> _uiAnimationsData;
		private CHandle<gameIBlackboard> _blackboard;

		[Ordinal(40)] 
		[RED("uiAnimationsData")] 
		public CHandle<SceneScreenUIAnimationsData> UiAnimationsData
		{
			get
			{
				if (_uiAnimationsData == null)
				{
					_uiAnimationsData = (CHandle<SceneScreenUIAnimationsData>) CR2WTypeManager.Create("handle:SceneScreenUIAnimationsData", "uiAnimationsData", cr2w, this);
				}
				return _uiAnimationsData;
			}
			set
			{
				if (_uiAnimationsData == value)
				{
					return;
				}
				_uiAnimationsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		public SceneScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
