using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemEmissive : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _brigtness;

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
		[RED("brigtness")] 
		public effectEffectParameterEvaluatorFloat Brigtness
		{
			get
			{
				if (_brigtness == null)
				{
					_brigtness = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "brigtness", cr2w, this);
				}
				return _brigtness;
			}
			set
			{
				if (_brigtness == value)
				{
					return;
				}
				_brigtness = value;
				PropertySet(this);
			}
		}

		public effectTrackItemEmissive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
