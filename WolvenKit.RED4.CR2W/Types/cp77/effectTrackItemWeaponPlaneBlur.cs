using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemWeaponPlaneBlur : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _farPlaneMultiplier;
		private CBool _override;

		[Ordinal(3)] 
		[RED("farPlaneMultiplier")] 
		public effectEffectParameterEvaluatorFloat FarPlaneMultiplier
		{
			get
			{
				if (_farPlaneMultiplier == null)
				{
					_farPlaneMultiplier = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "farPlaneMultiplier", cr2w, this);
				}
				return _farPlaneMultiplier;
			}
			set
			{
				if (_farPlaneMultiplier == value)
				{
					return;
				}
				_farPlaneMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public effectTrackItemWeaponPlaneBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
