using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360Direction : animAnimNode_FloatValue
	{
		private CFloat _angleOffset;
		private CFloat _defaultValue;
		private CBool _negateOutput;

		[Ordinal(11)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CFloat) CR2WTypeManager.Create("Float", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CFloat) CR2WTypeManager.Create("Float", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("negateOutput")] 
		public CBool NegateOutput
		{
			get
			{
				if (_negateOutput == null)
				{
					_negateOutput = (CBool) CR2WTypeManager.Create("Bool", "negateOutput", cr2w, this);
				}
				return _negateOutput;
			}
			set
			{
				if (_negateOutput == value)
				{
					return;
				}
				_negateOutput = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LookAtPose360Direction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
