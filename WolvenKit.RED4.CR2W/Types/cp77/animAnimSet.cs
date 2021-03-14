using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSet : CResource
	{
		private CArray<CHandle<animAnimSetEntry>> _animations;
		private CArray<animAnimDataChunk> _animationDataChunks;
		private rRef<animRig> _rig;
		private redTagList _tags;
		private rRef<CResource> _correspondingArchetype;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<CHandle<animAnimSetEntry>> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<CHandle<animAnimSetEntry>>) CR2WTypeManager.Create("array:handle:animAnimSetEntry", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationDataChunks")] 
		public CArray<animAnimDataChunk> AnimationDataChunks
		{
			get
			{
				if (_animationDataChunks == null)
				{
					_animationDataChunks = (CArray<animAnimDataChunk>) CR2WTypeManager.Create("array:animAnimDataChunk", "animationDataChunks", cr2w, this);
				}
				return _animationDataChunks;
			}
			set
			{
				if (_animationDataChunks == value)
				{
					return;
				}
				_animationDataChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("correspondingArchetype")] 
		public rRef<CResource> CorrespondingArchetype
		{
			get
			{
				if (_correspondingArchetype == null)
				{
					_correspondingArchetype = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "correspondingArchetype", cr2w, this);
				}
				return _correspondingArchetype;
			}
			set
			{
				if (_correspondingArchetype == value)
				{
					return;
				}
				_correspondingArchetype = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public animAnimSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
