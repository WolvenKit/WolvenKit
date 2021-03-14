using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		private CFloat _texturesPerUnit;
		private CBool _dynamicTexCoords;
		private CInt32 _minSegmentsPer360Degrees;
		private CBool _ribbonize;
		private CFloat _ribbonTesselationDelta;

		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get
			{
				if (_texturesPerUnit == null)
				{
					_texturesPerUnit = (CFloat) CR2WTypeManager.Create("Float", "texturesPerUnit", cr2w, this);
				}
				return _texturesPerUnit;
			}
			set
			{
				if (_texturesPerUnit == value)
				{
					return;
				}
				_texturesPerUnit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get
			{
				if (_dynamicTexCoords == null)
				{
					_dynamicTexCoords = (CBool) CR2WTypeManager.Create("Bool", "dynamicTexCoords", cr2w, this);
				}
				return _dynamicTexCoords;
			}
			set
			{
				if (_dynamicTexCoords == value)
				{
					return;
				}
				_dynamicTexCoords = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minSegmentsPer360Degrees")] 
		public CInt32 MinSegmentsPer360Degrees
		{
			get
			{
				if (_minSegmentsPer360Degrees == null)
				{
					_minSegmentsPer360Degrees = (CInt32) CR2WTypeManager.Create("Int32", "minSegmentsPer360Degrees", cr2w, this);
				}
				return _minSegmentsPer360Degrees;
			}
			set
			{
				if (_minSegmentsPer360Degrees == value)
				{
					return;
				}
				_minSegmentsPer360Degrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ribbonize")] 
		public CBool Ribbonize
		{
			get
			{
				if (_ribbonize == null)
				{
					_ribbonize = (CBool) CR2WTypeManager.Create("Bool", "ribbonize", cr2w, this);
				}
				return _ribbonize;
			}
			set
			{
				if (_ribbonize == value)
				{
					return;
				}
				_ribbonize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ribbonTesselationDelta")] 
		public CFloat RibbonTesselationDelta
		{
			get
			{
				if (_ribbonTesselationDelta == null)
				{
					_ribbonTesselationDelta = (CFloat) CR2WTypeManager.Create("Float", "ribbonTesselationDelta", cr2w, this);
				}
				return _ribbonTesselationDelta;
			}
			set
			{
				if (_ribbonTesselationDelta == value)
				{
					return;
				}
				_ribbonTesselationDelta = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
