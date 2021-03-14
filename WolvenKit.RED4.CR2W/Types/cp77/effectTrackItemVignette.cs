using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemVignette : effectTrackItem
	{
		private CBool _overrideRadiusAndExp;
		private CBool _overrideColor;
		private effectEffectParameterEvaluatorFloat _vignetteRadius;
		private effectEffectParameterEvaluatorFloat _vignetteExp;
		private effectEffectParameterEvaluatorColor _color;

		[Ordinal(3)] 
		[RED("overrideRadiusAndExp")] 
		public CBool OverrideRadiusAndExp
		{
			get
			{
				if (_overrideRadiusAndExp == null)
				{
					_overrideRadiusAndExp = (CBool) CR2WTypeManager.Create("Bool", "overrideRadiusAndExp", cr2w, this);
				}
				return _overrideRadiusAndExp;
			}
			set
			{
				if (_overrideRadiusAndExp == value)
				{
					return;
				}
				_overrideRadiusAndExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("overrideColor")] 
		public CBool OverrideColor
		{
			get
			{
				if (_overrideColor == null)
				{
					_overrideColor = (CBool) CR2WTypeManager.Create("Bool", "overrideColor", cr2w, this);
				}
				return _overrideColor;
			}
			set
			{
				if (_overrideColor == value)
				{
					return;
				}
				_overrideColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vignetteRadius")] 
		public effectEffectParameterEvaluatorFloat VignetteRadius
		{
			get
			{
				if (_vignetteRadius == null)
				{
					_vignetteRadius = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "vignetteRadius", cr2w, this);
				}
				return _vignetteRadius;
			}
			set
			{
				if (_vignetteRadius == value)
				{
					return;
				}
				_vignetteRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vignetteExp")] 
		public effectEffectParameterEvaluatorFloat VignetteExp
		{
			get
			{
				if (_vignetteExp == null)
				{
					_vignetteExp = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "vignetteExp", cr2w, this);
				}
				return _vignetteExp;
			}
			set
			{
				if (_vignetteExp == value)
				{
					return;
				}
				_vignetteExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("color")] 
		public effectEffectParameterEvaluatorColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (effectEffectParameterEvaluatorColor) CR2WTypeManager.Create("effectEffectParameterEvaluatorColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public effectTrackItemVignette(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
