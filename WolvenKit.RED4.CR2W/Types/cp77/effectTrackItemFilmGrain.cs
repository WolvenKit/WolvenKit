using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFilmGrain : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _luminanceBias;
		private effectEffectParameterEvaluatorVector _strength;

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
		[RED("luminanceBias")] 
		public effectEffectParameterEvaluatorFloat LuminanceBias
		{
			get
			{
				if (_luminanceBias == null)
				{
					_luminanceBias = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "luminanceBias", cr2w, this);
				}
				return _luminanceBias;
			}
			set
			{
				if (_luminanceBias == value)
				{
					return;
				}
				_luminanceBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("strength")] 
		public effectEffectParameterEvaluatorVector Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		public effectTrackItemFilmGrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
