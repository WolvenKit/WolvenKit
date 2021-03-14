using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimationRid_ : CVariable
	{
		private scnRidTag _tag;
		private CHandle<animAnimation> _animation;
		private CHandle<animEventsContainer> _events;
		private CBool _motionExtracted;
		private Transform _offset;
		private CUInt32 _bonesCount;
		private CInt32 _trajectoryBoneIndex;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (scnRidTag) CR2WTypeManager.Create("scnRidTag", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animation")] 
		public CHandle<animAnimation> Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CHandle<animAnimation>) CR2WTypeManager.Create("handle:animAnimation", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CHandle<animEventsContainer>) CR2WTypeManager.Create("handle:animEventsContainer", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("motionExtracted")] 
		public CBool MotionExtracted
		{
			get
			{
				if (_motionExtracted == null)
				{
					_motionExtracted = (CBool) CR2WTypeManager.Create("Bool", "motionExtracted", cr2w, this);
				}
				return _motionExtracted;
			}
			set
			{
				if (_motionExtracted == value)
				{
					return;
				}
				_motionExtracted = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Transform Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Transform) CR2WTypeManager.Create("Transform", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bonesCount")] 
		public CUInt32 BonesCount
		{
			get
			{
				if (_bonesCount == null)
				{
					_bonesCount = (CUInt32) CR2WTypeManager.Create("Uint32", "bonesCount", cr2w, this);
				}
				return _bonesCount;
			}
			set
			{
				if (_bonesCount == value)
				{
					return;
				}
				_bonesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("trajectoryBoneIndex")] 
		public CInt32 TrajectoryBoneIndex
		{
			get
			{
				if (_trajectoryBoneIndex == null)
				{
					_trajectoryBoneIndex = (CInt32) CR2WTypeManager.Create("Int32", "trajectoryBoneIndex", cr2w, this);
				}
				return _trajectoryBoneIndex;
			}
			set
			{
				if (_trajectoryBoneIndex == value)
				{
					return;
				}
				_trajectoryBoneIndex = value;
				PropertySet(this);
			}
		}

		public scnAnimationRid_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
