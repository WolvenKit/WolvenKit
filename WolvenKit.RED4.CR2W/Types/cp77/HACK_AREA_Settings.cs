using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HACK_AREA_Settings : IAreaSettings
	{
		private CFloat _surfelScale;
		private CFloat _missingEnergyScale;
		private CBool _overrideOnPureView;
		private CFloat _surfAlbedoOverrideRatio;
		private HDRColor _surfAlbedoOverride;
		private CFloat _skyScale;
		private curveData<HDRColor> _bottomHemisphereTint;
		private CFloat _bottomHemisphereStrength;
		private CFloat _emissiveScale;

		[Ordinal(2)] 
		[RED("surfelScale")] 
		public CFloat SurfelScale
		{
			get
			{
				if (_surfelScale == null)
				{
					_surfelScale = (CFloat) CR2WTypeManager.Create("Float", "surfelScale", cr2w, this);
				}
				return _surfelScale;
			}
			set
			{
				if (_surfelScale == value)
				{
					return;
				}
				_surfelScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("missingEnergyScale")] 
		public CFloat MissingEnergyScale
		{
			get
			{
				if (_missingEnergyScale == null)
				{
					_missingEnergyScale = (CFloat) CR2WTypeManager.Create("Float", "missingEnergyScale", cr2w, this);
				}
				return _missingEnergyScale;
			}
			set
			{
				if (_missingEnergyScale == value)
				{
					return;
				}
				_missingEnergyScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("overrideOnPureView")] 
		public CBool OverrideOnPureView
		{
			get
			{
				if (_overrideOnPureView == null)
				{
					_overrideOnPureView = (CBool) CR2WTypeManager.Create("Bool", "overrideOnPureView", cr2w, this);
				}
				return _overrideOnPureView;
			}
			set
			{
				if (_overrideOnPureView == value)
				{
					return;
				}
				_overrideOnPureView = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("surfAlbedoOverrideRatio")] 
		public CFloat SurfAlbedoOverrideRatio
		{
			get
			{
				if (_surfAlbedoOverrideRatio == null)
				{
					_surfAlbedoOverrideRatio = (CFloat) CR2WTypeManager.Create("Float", "surfAlbedoOverrideRatio", cr2w, this);
				}
				return _surfAlbedoOverrideRatio;
			}
			set
			{
				if (_surfAlbedoOverrideRatio == value)
				{
					return;
				}
				_surfAlbedoOverrideRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("surfAlbedoOverride")] 
		public HDRColor SurfAlbedoOverride
		{
			get
			{
				if (_surfAlbedoOverride == null)
				{
					_surfAlbedoOverride = (HDRColor) CR2WTypeManager.Create("HDRColor", "surfAlbedoOverride", cr2w, this);
				}
				return _surfAlbedoOverride;
			}
			set
			{
				if (_surfAlbedoOverride == value)
				{
					return;
				}
				_surfAlbedoOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get
			{
				if (_skyScale == null)
				{
					_skyScale = (CFloat) CR2WTypeManager.Create("Float", "skyScale", cr2w, this);
				}
				return _skyScale;
			}
			set
			{
				if (_skyScale == value)
				{
					return;
				}
				_skyScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bottomHemisphereTint")] 
		public curveData<HDRColor> BottomHemisphereTint
		{
			get
			{
				if (_bottomHemisphereTint == null)
				{
					_bottomHemisphereTint = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "bottomHemisphereTint", cr2w, this);
				}
				return _bottomHemisphereTint;
			}
			set
			{
				if (_bottomHemisphereTint == value)
				{
					return;
				}
				_bottomHemisphereTint = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bottomHemisphereStrength")] 
		public CFloat BottomHemisphereStrength
		{
			get
			{
				if (_bottomHemisphereStrength == null)
				{
					_bottomHemisphereStrength = (CFloat) CR2WTypeManager.Create("Float", "bottomHemisphereStrength", cr2w, this);
				}
				return _bottomHemisphereStrength;
			}
			set
			{
				if (_bottomHemisphereStrength == value)
				{
					return;
				}
				_bottomHemisphereStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get
			{
				if (_emissiveScale == null)
				{
					_emissiveScale = (CFloat) CR2WTypeManager.Create("Float", "emissiveScale", cr2w, this);
				}
				return _emissiveScale;
			}
			set
			{
				if (_emissiveScale == value)
				{
					return;
				}
				_emissiveScale = value;
				PropertySet(this);
			}
		}

		public HACK_AREA_Settings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
