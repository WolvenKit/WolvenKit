using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSnapToTerrainIkRequest : CVariable
	{
		private CName _ikChain;
		private animTransformIndex _footTransformIndex;
		private animTransformIndex _poleVectorRefTransformIndex;
		private animNamedTrackIndex _enableFootLockFloatTrack;

		[Ordinal(0)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get
			{
				if (_ikChain == null)
				{
					_ikChain = (CName) CR2WTypeManager.Create("CName", "ikChain", cr2w, this);
				}
				return _ikChain;
			}
			set
			{
				if (_ikChain == value)
				{
					return;
				}
				_ikChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("footTransformIndex")] 
		public animTransformIndex FootTransformIndex
		{
			get
			{
				if (_footTransformIndex == null)
				{
					_footTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "footTransformIndex", cr2w, this);
				}
				return _footTransformIndex;
			}
			set
			{
				if (_footTransformIndex == value)
				{
					return;
				}
				_footTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("poleVectorRefTransformIndex")] 
		public animTransformIndex PoleVectorRefTransformIndex
		{
			get
			{
				if (_poleVectorRefTransformIndex == null)
				{
					_poleVectorRefTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "poleVectorRefTransformIndex", cr2w, this);
				}
				return _poleVectorRefTransformIndex;
			}
			set
			{
				if (_poleVectorRefTransformIndex == value)
				{
					return;
				}
				_poleVectorRefTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enableFootLockFloatTrack")] 
		public animNamedTrackIndex EnableFootLockFloatTrack
		{
			get
			{
				if (_enableFootLockFloatTrack == null)
				{
					_enableFootLockFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "enableFootLockFloatTrack", cr2w, this);
				}
				return _enableFootLockFloatTrack;
			}
			set
			{
				if (_enableFootLockFloatTrack == value)
				{
					return;
				}
				_enableFootLockFloatTrack = value;
				PropertySet(this);
			}
		}

		public animSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
