using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		private CFloat _x1;
		private CFloat _x2;
		private CFloat _y1;
		private CFloat _y2;
		private CEnum<animEAnimGraphMathInterpolation> _interpolationType;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("x1")] 
		public CFloat X1
		{
			get
			{
				if (_x1 == null)
				{
					_x1 = (CFloat) CR2WTypeManager.Create("Float", "x1", cr2w, this);
				}
				return _x1;
			}
			set
			{
				if (_x1 == value)
				{
					return;
				}
				_x1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("x2")] 
		public CFloat X2
		{
			get
			{
				if (_x2 == null)
				{
					_x2 = (CFloat) CR2WTypeManager.Create("Float", "x2", cr2w, this);
				}
				return _x2;
			}
			set
			{
				if (_x2 == value)
				{
					return;
				}
				_x2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("y1")] 
		public CFloat Y1
		{
			get
			{
				if (_y1 == null)
				{
					_y1 = (CFloat) CR2WTypeManager.Create("Float", "y1", cr2w, this);
				}
				return _y1;
			}
			set
			{
				if (_y1 == value)
				{
					return;
				}
				_y1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("y2")] 
		public CFloat Y2
		{
			get
			{
				if (_y2 == null)
				{
					_y2 = (CFloat) CR2WTypeManager.Create("Float", "y2", cr2w, this);
				}
				return _y2;
			}
			set
			{
				if (_y2 == value)
				{
					return;
				}
				_y2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("interpolationType")] 
		public CEnum<animEAnimGraphMathInterpolation> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<animEAnimGraphMathInterpolation>) CR2WTypeManager.Create("animEAnimGraphMathInterpolation", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
