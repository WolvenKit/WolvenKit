using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KillMarkerGameController : gameuiWidgetGameController
	{
		private CUInt32 _targetNeutralized;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("targetNeutralized")] 
		public CUInt32 TargetNeutralized
		{
			get
			{
				if (_targetNeutralized == null)
				{
					_targetNeutralized = (CUInt32) CR2WTypeManager.Create("Uint32", "targetNeutralized", cr2w, this);
				}
				return _targetNeutralized;
			}
			set
			{
				if (_targetNeutralized == value)
				{
					return;
				}
				_targetNeutralized = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public KillMarkerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
