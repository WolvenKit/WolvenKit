using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponScopeData : animAnimFeature
	{
		private CFloat _ironsightAngleWithScope;
		private CBool _hasScope;

		[Ordinal(0)] 
		[RED("ironsightAngleWithScope")] 
		public CFloat IronsightAngleWithScope
		{
			get
			{
				if (_ironsightAngleWithScope == null)
				{
					_ironsightAngleWithScope = (CFloat) CR2WTypeManager.Create("Float", "ironsightAngleWithScope", cr2w, this);
				}
				return _ironsightAngleWithScope;
			}
			set
			{
				if (_ironsightAngleWithScope == value)
				{
					return;
				}
				_ironsightAngleWithScope = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get
			{
				if (_hasScope == null)
				{
					_hasScope = (CBool) CR2WTypeManager.Create("Bool", "hasScope", cr2w, this);
				}
				return _hasScope;
			}
			set
			{
				if (_hasScope == value)
				{
					return;
				}
				_hasScope = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponScopeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
