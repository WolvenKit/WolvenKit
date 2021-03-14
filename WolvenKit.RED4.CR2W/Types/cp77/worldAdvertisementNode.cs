using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAdvertisementNode : worldStaticMeshNode
	{
		private Vector3 _meshInitialScale;
		private CEnum<AdvertisementFormat> _format;
		private TweakDBID _adGroupTDBID;
		private CBool _enableOverride;
		private TweakDBID _adOverrideTDBID;
		private CUInt32 _adVersion;
		private CFloat _glitchValue;
		private CArray<worldAdvertisementLightData> _lightsData;

		[Ordinal(15)] 
		[RED("meshInitialScale")] 
		public Vector3 MeshInitialScale
		{
			get
			{
				if (_meshInitialScale == null)
				{
					_meshInitialScale = (Vector3) CR2WTypeManager.Create("Vector3", "meshInitialScale", cr2w, this);
				}
				return _meshInitialScale;
			}
			set
			{
				if (_meshInitialScale == value)
				{
					return;
				}
				_meshInitialScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("format")] 
		public CEnum<AdvertisementFormat> Format
		{
			get
			{
				if (_format == null)
				{
					_format = (CEnum<AdvertisementFormat>) CR2WTypeManager.Create("AdvertisementFormat", "format", cr2w, this);
				}
				return _format;
			}
			set
			{
				if (_format == value)
				{
					return;
				}
				_format = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("adGroupTDBID")] 
		public TweakDBID AdGroupTDBID
		{
			get
			{
				if (_adGroupTDBID == null)
				{
					_adGroupTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "adGroupTDBID", cr2w, this);
				}
				return _adGroupTDBID;
			}
			set
			{
				if (_adGroupTDBID == value)
				{
					return;
				}
				_adGroupTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("enableOverride")] 
		public CBool EnableOverride
		{
			get
			{
				if (_enableOverride == null)
				{
					_enableOverride = (CBool) CR2WTypeManager.Create("Bool", "enableOverride", cr2w, this);
				}
				return _enableOverride;
			}
			set
			{
				if (_enableOverride == value)
				{
					return;
				}
				_enableOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("adOverrideTDBID")] 
		public TweakDBID AdOverrideTDBID
		{
			get
			{
				if (_adOverrideTDBID == null)
				{
					_adOverrideTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "adOverrideTDBID", cr2w, this);
				}
				return _adOverrideTDBID;
			}
			set
			{
				if (_adOverrideTDBID == value)
				{
					return;
				}
				_adOverrideTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("adVersion")] 
		public CUInt32 AdVersion
		{
			get
			{
				if (_adVersion == null)
				{
					_adVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "adVersion", cr2w, this);
				}
				return _adVersion;
			}
			set
			{
				if (_adVersion == value)
				{
					return;
				}
				_adVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get
			{
				if (_glitchValue == null)
				{
					_glitchValue = (CFloat) CR2WTypeManager.Create("Float", "glitchValue", cr2w, this);
				}
				return _glitchValue;
			}
			set
			{
				if (_glitchValue == value)
				{
					return;
				}
				_glitchValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("lightsData")] 
		public CArray<worldAdvertisementLightData> LightsData
		{
			get
			{
				if (_lightsData == null)
				{
					_lightsData = (CArray<worldAdvertisementLightData>) CR2WTypeManager.Create("array:worldAdvertisementLightData", "lightsData", cr2w, this);
				}
				return _lightsData;
			}
			set
			{
				if (_lightsData == value)
				{
					return;
				}
				_lightsData = value;
				PropertySet(this);
			}
		}

		public worldAdvertisementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
