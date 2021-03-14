using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		private CBool _safeMode;
		private CUInt32 _transformsCountUpperBound;
		private CUInt32 _tracksCountUpperBound;
		private CArray<animInertializationRotationLimit> _rotationLimits;

		[Ordinal(12)] 
		[RED("safeMode")] 
		public CBool SafeMode
		{
			get
			{
				if (_safeMode == null)
				{
					_safeMode = (CBool) CR2WTypeManager.Create("Bool", "safeMode", cr2w, this);
				}
				return _safeMode;
			}
			set
			{
				if (_safeMode == value)
				{
					return;
				}
				_safeMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transformsCountUpperBound")] 
		public CUInt32 TransformsCountUpperBound
		{
			get
			{
				if (_transformsCountUpperBound == null)
				{
					_transformsCountUpperBound = (CUInt32) CR2WTypeManager.Create("Uint32", "transformsCountUpperBound", cr2w, this);
				}
				return _transformsCountUpperBound;
			}
			set
			{
				if (_transformsCountUpperBound == value)
				{
					return;
				}
				_transformsCountUpperBound = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tracksCountUpperBound")] 
		public CUInt32 TracksCountUpperBound
		{
			get
			{
				if (_tracksCountUpperBound == null)
				{
					_tracksCountUpperBound = (CUInt32) CR2WTypeManager.Create("Uint32", "tracksCountUpperBound", cr2w, this);
				}
				return _tracksCountUpperBound;
			}
			set
			{
				if (_tracksCountUpperBound == value)
				{
					return;
				}
				_tracksCountUpperBound = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rotationLimits")] 
		public CArray<animInertializationRotationLimit> RotationLimits
		{
			get
			{
				if (_rotationLimits == null)
				{
					_rotationLimits = (CArray<animInertializationRotationLimit>) CR2WTypeManager.Create("array:animInertializationRotationLimit", "rotationLimits", cr2w, this);
				}
				return _rotationLimits;
			}
			set
			{
				if (_rotationLimits == value)
				{
					return;
				}
				_rotationLimits = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Inertialization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
