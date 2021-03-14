using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEvent : scnPlayFPPControlAnimEvent
	{
		private CHandle<scnAnimName> _animName;
		private CHandle<scnEventBlendWorkspotSetupParameters> _poseBlendOutWorkspot;
		private scnPlaySkAnimRootMotionData _rootMotionData;
		private scnPlayerAnimData _playerData;

		[Ordinal(31)] 
		[RED("animName")] 
		public CHandle<scnAnimName> AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CHandle<scnAnimName>) CR2WTypeManager.Create("handle:scnAnimName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("poseBlendOutWorkspot")] 
		public CHandle<scnEventBlendWorkspotSetupParameters> PoseBlendOutWorkspot
		{
			get
			{
				if (_poseBlendOutWorkspot == null)
				{
					_poseBlendOutWorkspot = (CHandle<scnEventBlendWorkspotSetupParameters>) CR2WTypeManager.Create("handle:scnEventBlendWorkspotSetupParameters", "poseBlendOutWorkspot", cr2w, this);
				}
				return _poseBlendOutWorkspot;
			}
			set
			{
				if (_poseBlendOutWorkspot == value)
				{
					return;
				}
				_poseBlendOutWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("rootMotionData")] 
		public scnPlaySkAnimRootMotionData RootMotionData
		{
			get
			{
				if (_rootMotionData == null)
				{
					_rootMotionData = (scnPlaySkAnimRootMotionData) CR2WTypeManager.Create("scnPlaySkAnimRootMotionData", "rootMotionData", cr2w, this);
				}
				return _rootMotionData;
			}
			set
			{
				if (_rootMotionData == value)
				{
					return;
				}
				_rootMotionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("playerData")] 
		public scnPlayerAnimData PlayerData
		{
			get
			{
				if (_playerData == null)
				{
					_playerData = (scnPlayerAnimData) CR2WTypeManager.Create("scnPlayerAnimData", "playerData", cr2w, this);
				}
				return _playerData;
			}
			set
			{
				if (_playerData == value)
				{
					return;
				}
				_playerData = value;
				PropertySet(this);
			}
		}

		public scnPlaySkAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
