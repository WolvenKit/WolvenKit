using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FoliageShadowConfig : CVariable
	{
		private CFloat _foliageShadowCascadeGradient;
		private CFloat _foliageShadowCascadeFilterScale;
		private CFloat _foliageShadowCascadeGradientDistanceRange;

		[Ordinal(0)] 
		[RED("foliageShadowCascadeGradient")] 
		public CFloat FoliageShadowCascadeGradient
		{
			get
			{
				if (_foliageShadowCascadeGradient == null)
				{
					_foliageShadowCascadeGradient = (CFloat) CR2WTypeManager.Create("Float", "foliageShadowCascadeGradient", cr2w, this);
				}
				return _foliageShadowCascadeGradient;
			}
			set
			{
				if (_foliageShadowCascadeGradient == value)
				{
					return;
				}
				_foliageShadowCascadeGradient = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("foliageShadowCascadeFilterScale")] 
		public CFloat FoliageShadowCascadeFilterScale
		{
			get
			{
				if (_foliageShadowCascadeFilterScale == null)
				{
					_foliageShadowCascadeFilterScale = (CFloat) CR2WTypeManager.Create("Float", "foliageShadowCascadeFilterScale", cr2w, this);
				}
				return _foliageShadowCascadeFilterScale;
			}
			set
			{
				if (_foliageShadowCascadeFilterScale == value)
				{
					return;
				}
				_foliageShadowCascadeFilterScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("foliageShadowCascadeGradientDistanceRange")] 
		public CFloat FoliageShadowCascadeGradientDistanceRange
		{
			get
			{
				if (_foliageShadowCascadeGradientDistanceRange == null)
				{
					_foliageShadowCascadeGradientDistanceRange = (CFloat) CR2WTypeManager.Create("Float", "foliageShadowCascadeGradientDistanceRange", cr2w, this);
				}
				return _foliageShadowCascadeGradientDistanceRange;
			}
			set
			{
				if (_foliageShadowCascadeGradientDistanceRange == value)
				{
					return;
				}
				_foliageShadowCascadeGradientDistanceRange = value;
				PropertySet(this);
			}
		}

		public FoliageShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
