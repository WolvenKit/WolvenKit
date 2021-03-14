using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeOrientationChangeSection : CVariable
	{
		private CFloat _pos;
		private CEnum<worldSpeedSplineOrientationMarkerType> _type;
		private EulerAngles _targetOrientation;

		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (CFloat) CR2WTypeManager.Create("Float", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldSpeedSplineOrientationMarkerType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldSpeedSplineOrientationMarkerType>) CR2WTypeManager.Create("worldSpeedSplineOrientationMarkerType", "type", cr2w, this);
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

		[Ordinal(2)] 
		[RED("targetOrientation")] 
		public EulerAngles TargetOrientation
		{
			get
			{
				if (_targetOrientation == null)
				{
					_targetOrientation = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "targetOrientation", cr2w, this);
				}
				return _targetOrientation;
			}
			set
			{
				if (_targetOrientation == value)
				{
					return;
				}
				_targetOrientation = value;
				PropertySet(this);
			}
		}

		public worldSpeedSplineNodeOrientationChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
