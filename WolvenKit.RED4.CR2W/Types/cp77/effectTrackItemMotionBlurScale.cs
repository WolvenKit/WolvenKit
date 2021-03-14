using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMotionBlurScale : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _scale;

		[Ordinal(3)] 
		[RED("scale")] 
		public effectEffectParameterEvaluatorFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		public effectTrackItemMotionBlurScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
