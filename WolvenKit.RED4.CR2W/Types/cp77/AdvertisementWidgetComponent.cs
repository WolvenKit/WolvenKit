using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		private CEnum<AdvertisementFormat> _format;
		private TweakDBID _adGroupTDBID;
		private CBool _enableOverride;
		private TweakDBID _adOverrideTDBID;
		private CUInt32 _adVersion;
		private CBool _useOnlyAttachedLights;

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("useOnlyAttachedLights")] 
		public CBool UseOnlyAttachedLights
		{
			get
			{
				if (_useOnlyAttachedLights == null)
				{
					_useOnlyAttachedLights = (CBool) CR2WTypeManager.Create("Bool", "useOnlyAttachedLights", cr2w, this);
				}
				return _useOnlyAttachedLights;
			}
			set
			{
				if (_useOnlyAttachedLights == value)
				{
					return;
				}
				_useOnlyAttachedLights = value;
				PropertySet(this);
			}
		}

		public AdvertisementWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
