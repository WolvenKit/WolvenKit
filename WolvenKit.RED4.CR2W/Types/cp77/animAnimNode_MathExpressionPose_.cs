using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionPose_ : animAnimNode_OnePoseInput
	{
		private animMathExpressionNodeData _expressionData;
		private animNamedTrackIndex _outputFloatTrack;

		[Ordinal(12)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get
			{
				if (_expressionData == null)
				{
					_expressionData = (animMathExpressionNodeData) CR2WTypeManager.Create("animMathExpressionNodeData", "expressionData", cr2w, this);
				}
				return _expressionData;
			}
			set
			{
				if (_expressionData == value)
				{
					return;
				}
				_expressionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outputFloatTrack")] 
		public animNamedTrackIndex OutputFloatTrack
		{
			get
			{
				if (_outputFloatTrack == null)
				{
					_outputFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "outputFloatTrack", cr2w, this);
				}
				return _outputFloatTrack;
			}
			set
			{
				if (_outputFloatTrack == value)
				{
					return;
				}
				_outputFloatTrack = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MathExpressionPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
