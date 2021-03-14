using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SuspensionLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animNamedTrackIndex _radiusTrack;
		private animNamedTrackIndex _deviationTrack;
		private CEnum<animAxis> _axis;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("radiusTrack")] 
		public animNamedTrackIndex RadiusTrack
		{
			get
			{
				if (_radiusTrack == null)
				{
					_radiusTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "radiusTrack", cr2w, this);
				}
				return _radiusTrack;
			}
			set
			{
				if (_radiusTrack == value)
				{
					return;
				}
				_radiusTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("deviationTrack")] 
		public animNamedTrackIndex DeviationTrack
		{
			get
			{
				if (_deviationTrack == null)
				{
					_deviationTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "deviationTrack", cr2w, this);
				}
				return _deviationTrack;
			}
			set
			{
				if (_deviationTrack == value)
				{
					return;
				}
				_deviationTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("axis")] 
		public CEnum<animAxis> Axis
		{
			get
			{
				if (_axis == null)
				{
					_axis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "axis", cr2w, this);
				}
				return _axis;
			}
			set
			{
				if (_axis == value)
				{
					return;
				}
				_axis = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SuspensionLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
