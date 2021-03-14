using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationInfoResource : CResource
	{
		private CUInt32 _version;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _headCustomizationOptions;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _bodyCustomizationOptions;
		private CArray<CHandle<gameuiCharacterCustomizationInfo>> _armsCustomizationOptions;
		private CArray<gameuiOptionsGroup> _armsGroups;
		private CArray<gameuiOptionsGroup> _headGroups;
		private CArray<gameuiOptionsGroup> _bodyGroups;
		private CArray<gameuiPerspectiveInfo> _perspectiveInfo;
		private CArray<gameuiCharacterCustomizationUiPresetInfo> _uiPresets;
		private CArray<CName> _excludedFromRandomize;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("headCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> HeadCustomizationOptions
		{
			get
			{
				if (_headCustomizationOptions == null)
				{
					_headCustomizationOptions = (CArray<CHandle<gameuiCharacterCustomizationInfo>>) CR2WTypeManager.Create("array:handle:gameuiCharacterCustomizationInfo", "headCustomizationOptions", cr2w, this);
				}
				return _headCustomizationOptions;
			}
			set
			{
				if (_headCustomizationOptions == value)
				{
					return;
				}
				_headCustomizationOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bodyCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> BodyCustomizationOptions
		{
			get
			{
				if (_bodyCustomizationOptions == null)
				{
					_bodyCustomizationOptions = (CArray<CHandle<gameuiCharacterCustomizationInfo>>) CR2WTypeManager.Create("array:handle:gameuiCharacterCustomizationInfo", "bodyCustomizationOptions", cr2w, this);
				}
				return _bodyCustomizationOptions;
			}
			set
			{
				if (_bodyCustomizationOptions == value)
				{
					return;
				}
				_bodyCustomizationOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("armsCustomizationOptions")] 
		public CArray<CHandle<gameuiCharacterCustomizationInfo>> ArmsCustomizationOptions
		{
			get
			{
				if (_armsCustomizationOptions == null)
				{
					_armsCustomizationOptions = (CArray<CHandle<gameuiCharacterCustomizationInfo>>) CR2WTypeManager.Create("array:handle:gameuiCharacterCustomizationInfo", "armsCustomizationOptions", cr2w, this);
				}
				return _armsCustomizationOptions;
			}
			set
			{
				if (_armsCustomizationOptions == value)
				{
					return;
				}
				_armsCustomizationOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("armsGroups")] 
		public CArray<gameuiOptionsGroup> ArmsGroups
		{
			get
			{
				if (_armsGroups == null)
				{
					_armsGroups = (CArray<gameuiOptionsGroup>) CR2WTypeManager.Create("array:gameuiOptionsGroup", "armsGroups", cr2w, this);
				}
				return _armsGroups;
			}
			set
			{
				if (_armsGroups == value)
				{
					return;
				}
				_armsGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("headGroups")] 
		public CArray<gameuiOptionsGroup> HeadGroups
		{
			get
			{
				if (_headGroups == null)
				{
					_headGroups = (CArray<gameuiOptionsGroup>) CR2WTypeManager.Create("array:gameuiOptionsGroup", "headGroups", cr2w, this);
				}
				return _headGroups;
			}
			set
			{
				if (_headGroups == value)
				{
					return;
				}
				_headGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bodyGroups")] 
		public CArray<gameuiOptionsGroup> BodyGroups
		{
			get
			{
				if (_bodyGroups == null)
				{
					_bodyGroups = (CArray<gameuiOptionsGroup>) CR2WTypeManager.Create("array:gameuiOptionsGroup", "bodyGroups", cr2w, this);
				}
				return _bodyGroups;
			}
			set
			{
				if (_bodyGroups == value)
				{
					return;
				}
				_bodyGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("perspectiveInfo")] 
		public CArray<gameuiPerspectiveInfo> PerspectiveInfo
		{
			get
			{
				if (_perspectiveInfo == null)
				{
					_perspectiveInfo = (CArray<gameuiPerspectiveInfo>) CR2WTypeManager.Create("array:gameuiPerspectiveInfo", "perspectiveInfo", cr2w, this);
				}
				return _perspectiveInfo;
			}
			set
			{
				if (_perspectiveInfo == value)
				{
					return;
				}
				_perspectiveInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("uiPresets")] 
		public CArray<gameuiCharacterCustomizationUiPresetInfo> UiPresets
		{
			get
			{
				if (_uiPresets == null)
				{
					_uiPresets = (CArray<gameuiCharacterCustomizationUiPresetInfo>) CR2WTypeManager.Create("array:gameuiCharacterCustomizationUiPresetInfo", "uiPresets", cr2w, this);
				}
				return _uiPresets;
			}
			set
			{
				if (_uiPresets == value)
				{
					return;
				}
				_uiPresets = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("excludedFromRandomize")] 
		public CArray<CName> ExcludedFromRandomize
		{
			get
			{
				if (_excludedFromRandomize == null)
				{
					_excludedFromRandomize = (CArray<CName>) CR2WTypeManager.Create("array:CName", "excludedFromRandomize", cr2w, this);
				}
				return _excludedFromRandomize;
			}
			set
			{
				if (_excludedFromRandomize == value)
				{
					return;
				}
				_excludedFromRandomize = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationInfoResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
