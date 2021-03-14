using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshImportedSnapPoint : ISerializable
	{
		private CMatrix _localToCloud;
		private CFloat _range;
		private CUInt8 _rotationAlignmentSteps;
		private meshImportedSnapTags _snapTags;

		[Ordinal(0)] 
		[RED("localToCloud")] 
		public CMatrix LocalToCloud
		{
			get
			{
				if (_localToCloud == null)
				{
					_localToCloud = (CMatrix) CR2WTypeManager.Create("Matrix", "localToCloud", cr2w, this);
				}
				return _localToCloud;
			}
			set
			{
				if (_localToCloud == value)
				{
					return;
				}
				_localToCloud = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotationAlignmentSteps")] 
		public CUInt8 RotationAlignmentSteps
		{
			get
			{
				if (_rotationAlignmentSteps == null)
				{
					_rotationAlignmentSteps = (CUInt8) CR2WTypeManager.Create("Uint8", "rotationAlignmentSteps", cr2w, this);
				}
				return _rotationAlignmentSteps;
			}
			set
			{
				if (_rotationAlignmentSteps == value)
				{
					return;
				}
				_rotationAlignmentSteps = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("snapTags")] 
		public meshImportedSnapTags SnapTags
		{
			get
			{
				if (_snapTags == null)
				{
					_snapTags = (meshImportedSnapTags) CR2WTypeManager.Create("meshImportedSnapTags", "snapTags", cr2w, this);
				}
				return _snapTags;
			}
			set
			{
				if (_snapTags == value)
				{
					return;
				}
				_snapTags = value;
				PropertySet(this);
			}
		}

		public meshMeshImportedSnapPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
