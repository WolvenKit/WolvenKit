using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationPreset : CResource
	{
		private CBool _isMale;
		private CArray<gameuiCustomizationGroup> _bodyGroups;
		private CArray<gameuiCustomizationGroup> _headGroups;
		private CArray<gameuiCustomizationGroup> _armsGroups;
		private CArray<gameuiPerspectiveInfo> _perspectiveInfo;
		private redTagList _tags;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get
			{
				if (_isMale == null)
				{
					_isMale = (CBool) CR2WTypeManager.Create("Bool", "isMale", cr2w, this);
				}
				return _isMale;
			}
			set
			{
				if (_isMale == value)
				{
					return;
				}
				_isMale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bodyGroups")] 
		public CArray<gameuiCustomizationGroup> BodyGroups
		{
			get
			{
				if (_bodyGroups == null)
				{
					_bodyGroups = (CArray<gameuiCustomizationGroup>) CR2WTypeManager.Create("array:gameuiCustomizationGroup", "bodyGroups", cr2w, this);
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

		[Ordinal(3)] 
		[RED("headGroups")] 
		public CArray<gameuiCustomizationGroup> HeadGroups
		{
			get
			{
				if (_headGroups == null)
				{
					_headGroups = (CArray<gameuiCustomizationGroup>) CR2WTypeManager.Create("array:gameuiCustomizationGroup", "headGroups", cr2w, this);
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

		[Ordinal(4)] 
		[RED("armsGroups")] 
		public CArray<gameuiCustomizationGroup> ArmsGroups
		{
			get
			{
				if (_armsGroups == null)
				{
					_armsGroups = (CArray<gameuiCustomizationGroup>) CR2WTypeManager.Create("array:gameuiCustomizationGroup", "armsGroups", cr2w, this);
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		public gameuiCharacterCustomizationPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
