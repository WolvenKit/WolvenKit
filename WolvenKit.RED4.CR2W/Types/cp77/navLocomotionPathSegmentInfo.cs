using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathSegmentInfo : CVariable
	{
		private CEnum<navLocomotionPathSegmentTypes> _type;
		private navSerializableSplineProgression _segmentEnd;
		private CUInt64 _offMeshLink;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<navLocomotionPathSegmentTypes> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<navLocomotionPathSegmentTypes>) CR2WTypeManager.Create("navLocomotionPathSegmentTypes", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("segmentEnd")] 
		public navSerializableSplineProgression SegmentEnd
		{
			get
			{
				if (_segmentEnd == null)
				{
					_segmentEnd = (navSerializableSplineProgression) CR2WTypeManager.Create("navSerializableSplineProgression", "segmentEnd", cr2w, this);
				}
				return _segmentEnd;
			}
			set
			{
				if (_segmentEnd == value)
				{
					return;
				}
				_segmentEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offMeshLink")] 
		public CUInt64 OffMeshLink
		{
			get
			{
				if (_offMeshLink == null)
				{
					_offMeshLink = (CUInt64) CR2WTypeManager.Create("Uint64", "offMeshLink", cr2w, this);
				}
				return _offMeshLink;
			}
			set
			{
				if (_offMeshLink == value)
				{
					return;
				}
				_offMeshLink = value;
				PropertySet(this);
			}
		}

		public navLocomotionPathSegmentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
