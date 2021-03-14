using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoveringArc : CVariable
	{
		private CFloat _leftAngle;
		private CFloat _rightAngle;
		private CFloat _verticalAngle;

		[Ordinal(0)] 
		[RED("leftAngle")] 
		public CFloat LeftAngle
		{
			get
			{
				if (_leftAngle == null)
				{
					_leftAngle = (CFloat) CR2WTypeManager.Create("Float", "leftAngle", cr2w, this);
				}
				return _leftAngle;
			}
			set
			{
				if (_leftAngle == value)
				{
					return;
				}
				_leftAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightAngle")] 
		public CFloat RightAngle
		{
			get
			{
				if (_rightAngle == null)
				{
					_rightAngle = (CFloat) CR2WTypeManager.Create("Float", "rightAngle", cr2w, this);
				}
				return _rightAngle;
			}
			set
			{
				if (_rightAngle == value)
				{
					return;
				}
				_rightAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("verticalAngle")] 
		public CFloat VerticalAngle
		{
			get
			{
				if (_verticalAngle == null)
				{
					_verticalAngle = (CFloat) CR2WTypeManager.Create("Float", "verticalAngle", cr2w, this);
				}
				return _verticalAngle;
			}
			set
			{
				if (_verticalAngle == value)
				{
					return;
				}
				_verticalAngle = value;
				PropertySet(this);
			}
		}

		public gameCoveringArc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
