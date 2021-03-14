using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageTooltipData : ATooltipData
	{
		private CString _title;
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _titleLocalizationPackage;
		private CHandle<gameUILocalizationDataPackage> _descriptionLocalizationPackage;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("TitleLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage
		{
			get
			{
				if (_titleLocalizationPackage == null)
				{
					_titleLocalizationPackage = (CHandle<gameUILocalizationDataPackage>) CR2WTypeManager.Create("handle:gameUILocalizationDataPackage", "TitleLocalizationPackage", cr2w, this);
				}
				return _titleLocalizationPackage;
			}
			set
			{
				if (_titleLocalizationPackage == value)
				{
					return;
				}
				_titleLocalizationPackage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DescriptionLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage
		{
			get
			{
				if (_descriptionLocalizationPackage == null)
				{
					_descriptionLocalizationPackage = (CHandle<gameUILocalizationDataPackage>) CR2WTypeManager.Create("handle:gameUILocalizationDataPackage", "DescriptionLocalizationPackage", cr2w, this);
				}
				return _descriptionLocalizationPackage;
			}
			set
			{
				if (_descriptionLocalizationPackage == value)
				{
					return;
				}
				_descriptionLocalizationPackage = value;
				PropertySet(this);
			}
		}

		public MessageTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
