using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemChromaticAberration : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _chromaticAberrationOffset;
		private effectEffectParameterEvaluatorFloat _chromaticAberrationExp;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CBool) CR2WTypeManager.Create("Bool", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationOffset")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset
		{
			get
			{
				if (_chromaticAberrationOffset == null)
				{
					_chromaticAberrationOffset = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "chromaticAberrationOffset", cr2w, this);
				}
				return _chromaticAberrationOffset;
			}
			set
			{
				if (_chromaticAberrationOffset == value)
				{
					return;
				}
				_chromaticAberrationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationExp
		{
			get
			{
				if (_chromaticAberrationExp == null)
				{
					_chromaticAberrationExp = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "chromaticAberrationExp", cr2w, this);
				}
				return _chromaticAberrationExp;
			}
			set
			{
				if (_chromaticAberrationExp == value)
				{
					return;
				}
				_chromaticAberrationExp = value;
				PropertySet(this);
			}
		}

		public effectTrackItemChromaticAberration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
