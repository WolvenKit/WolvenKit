using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRewindableSectionTimeJump_NodeType : questISceneManagerNodeType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CUInt32 _jumpTargetTime;
		private CFloat _jumpSpeed;
		private CEnum<scnPlayDirection> _postJumpPlayDirection;
		private CEnum<scnPlaySpeed> _postJumpPlaySpeed;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("jumpTargetTime")] 
		public CUInt32 JumpTargetTime
		{
			get
			{
				if (_jumpTargetTime == null)
				{
					_jumpTargetTime = (CUInt32) CR2WTypeManager.Create("Uint32", "jumpTargetTime", cr2w, this);
				}
				return _jumpTargetTime;
			}
			set
			{
				if (_jumpTargetTime == value)
				{
					return;
				}
				_jumpTargetTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jumpSpeed")] 
		public CFloat JumpSpeed
		{
			get
			{
				if (_jumpSpeed == null)
				{
					_jumpSpeed = (CFloat) CR2WTypeManager.Create("Float", "jumpSpeed", cr2w, this);
				}
				return _jumpSpeed;
			}
			set
			{
				if (_jumpSpeed == value)
				{
					return;
				}
				_jumpSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("postJumpPlayDirection")] 
		public CEnum<scnPlayDirection> PostJumpPlayDirection
		{
			get
			{
				if (_postJumpPlayDirection == null)
				{
					_postJumpPlayDirection = (CEnum<scnPlayDirection>) CR2WTypeManager.Create("scnPlayDirection", "postJumpPlayDirection", cr2w, this);
				}
				return _postJumpPlayDirection;
			}
			set
			{
				if (_postJumpPlayDirection == value)
				{
					return;
				}
				_postJumpPlayDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("postJumpPlaySpeed")] 
		public CEnum<scnPlaySpeed> PostJumpPlaySpeed
		{
			get
			{
				if (_postJumpPlaySpeed == null)
				{
					_postJumpPlaySpeed = (CEnum<scnPlaySpeed>) CR2WTypeManager.Create("scnPlaySpeed", "postJumpPlaySpeed", cr2w, this);
				}
				return _postJumpPlaySpeed;
			}
			set
			{
				if (_postJumpPlaySpeed == value)
				{
					return;
				}
				_postJumpPlaySpeed = value;
				PropertySet(this);
			}
		}

		public questRewindableSectionTimeJump_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
