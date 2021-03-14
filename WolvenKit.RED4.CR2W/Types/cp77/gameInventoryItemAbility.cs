using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryItemAbility : CVariable
	{
		private CName _iconPath;
		private CString _title;
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _localizationDataPackage;

		[Ordinal(0)] 
		[RED("IconPath")] 
		public CName IconPath
		{
			get
			{
				if (_iconPath == null)
				{
					_iconPath = (CName) CR2WTypeManager.Create("CName", "IconPath", cr2w, this);
				}
				return _iconPath;
			}
			set
			{
				if (_iconPath == value)
				{
					return;
				}
				_iconPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "Title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "Description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("LocalizationDataPackage")] 
		public CHandle<gameUILocalizationDataPackage> LocalizationDataPackage
		{
			get
			{
				if (_localizationDataPackage == null)
				{
					_localizationDataPackage = (CHandle<gameUILocalizationDataPackage>) CR2WTypeManager.Create("handle:gameUILocalizationDataPackage", "LocalizationDataPackage", cr2w, this);
				}
				return _localizationDataPackage;
			}
			set
			{
				if (_localizationDataPackage == value)
				{
					return;
				}
				_localizationDataPackage = value;
				PropertySet(this);
			}
		}

		public gameInventoryItemAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
