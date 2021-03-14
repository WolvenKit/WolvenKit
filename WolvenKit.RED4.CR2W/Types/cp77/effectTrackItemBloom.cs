using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemBloom : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _sceneColorScale;
		private effectEffectParameterEvaluatorFloat _bloomColorScale;

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
		[RED("sceneColorScale")] 
		public effectEffectParameterEvaluatorFloat SceneColorScale
		{
			get
			{
				if (_sceneColorScale == null)
				{
					_sceneColorScale = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "sceneColorScale", cr2w, this);
				}
				return _sceneColorScale;
			}
			set
			{
				if (_sceneColorScale == value)
				{
					return;
				}
				_sceneColorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public effectEffectParameterEvaluatorFloat BloomColorScale
		{
			get
			{
				if (_bloomColorScale == null)
				{
					_bloomColorScale = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "bloomColorScale", cr2w, this);
				}
				return _bloomColorScale;
			}
			set
			{
				if (_bloomColorScale == value)
				{
					return;
				}
				_bloomColorScale = value;
				PropertySet(this);
			}
		}

		public effectTrackItemBloom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
