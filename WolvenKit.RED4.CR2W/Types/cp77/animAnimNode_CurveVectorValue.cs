using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CurveVectorValue : animAnimNode_VectorValue
	{
		private curveData<Vector4> _curveData;
		private animFloatLink _argument;

		[Ordinal(11)] 
		[RED("curveData")] 
		public curveData<Vector4> CurveData
		{
			get
			{
				if (_curveData == null)
				{
					_curveData = (curveData<Vector4>) CR2WTypeManager.Create("curveData:Vector4", "curveData", cr2w, this);
				}
				return _curveData;
			}
			set
			{
				if (_curveData == value)
				{
					return;
				}
				_curveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get
			{
				if (_argument == null)
				{
					_argument = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "argument", cr2w, this);
				}
				return _argument;
			}
			set
			{
				if (_argument == value)
				{
					return;
				}
				_argument = value;
				PropertySet(this);
			}
		}

		public animAnimNode_CurveVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
