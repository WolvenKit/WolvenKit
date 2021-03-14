using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_BufferInfo : CVariable
	{
		private animFacialSetup_TracksMapping _tracksMapping;
		private CUInt16 _numLipsyncOverridesIndexMapping;
		private CUInt16 _numJointRegions;
		private animFacialSetup_OneSermoBufferInfo _face;
		private animFacialSetup_OneSermoBufferInfo _eyes;
		private animFacialSetup_OneSermoBufferInfo _tongue;

		[Ordinal(0)] 
		[RED("tracksMapping")] 
		public animFacialSetup_TracksMapping TracksMapping
		{
			get
			{
				if (_tracksMapping == null)
				{
					_tracksMapping = (animFacialSetup_TracksMapping) CR2WTypeManager.Create("animFacialSetup_TracksMapping", "tracksMapping", cr2w, this);
				}
				return _tracksMapping;
			}
			set
			{
				if (_tracksMapping == value)
				{
					return;
				}
				_tracksMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numLipsyncOverridesIndexMapping")] 
		public CUInt16 NumLipsyncOverridesIndexMapping
		{
			get
			{
				if (_numLipsyncOverridesIndexMapping == null)
				{
					_numLipsyncOverridesIndexMapping = (CUInt16) CR2WTypeManager.Create("Uint16", "numLipsyncOverridesIndexMapping", cr2w, this);
				}
				return _numLipsyncOverridesIndexMapping;
			}
			set
			{
				if (_numLipsyncOverridesIndexMapping == value)
				{
					return;
				}
				_numLipsyncOverridesIndexMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numJointRegions")] 
		public CUInt16 NumJointRegions
		{
			get
			{
				if (_numJointRegions == null)
				{
					_numJointRegions = (CUInt16) CR2WTypeManager.Create("Uint16", "numJointRegions", cr2w, this);
				}
				return _numJointRegions;
			}
			set
			{
				if (_numJointRegions == value)
				{
					return;
				}
				_numJointRegions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("face")] 
		public animFacialSetup_OneSermoBufferInfo Face
		{
			get
			{
				if (_face == null)
				{
					_face = (animFacialSetup_OneSermoBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoBufferInfo", "face", cr2w, this);
				}
				return _face;
			}
			set
			{
				if (_face == value)
				{
					return;
				}
				_face = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoBufferInfo Eyes
		{
			get
			{
				if (_eyes == null)
				{
					_eyes = (animFacialSetup_OneSermoBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoBufferInfo", "eyes", cr2w, this);
				}
				return _eyes;
			}
			set
			{
				if (_eyes == value)
				{
					return;
				}
				_eyes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoBufferInfo Tongue
		{
			get
			{
				if (_tongue == null)
				{
					_tongue = (animFacialSetup_OneSermoBufferInfo) CR2WTypeManager.Create("animFacialSetup_OneSermoBufferInfo", "tongue", cr2w, this);
				}
				return _tongue;
			}
			set
			{
				if (_tongue == value)
				{
					return;
				}
				_tongue = value;
				PropertySet(this);
			}
		}

		public animFacialSetup_BufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
