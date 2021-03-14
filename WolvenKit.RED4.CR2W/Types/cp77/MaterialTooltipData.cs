using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltipData : ATooltipData
	{
		private CString _title;
		private CInt32 _baseMaterialQuantity;
		private CInt32 _materialQuantity;
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
		[RED("BaseMaterialQuantity")] 
		public CInt32 BaseMaterialQuantity
		{
			get
			{
				if (_baseMaterialQuantity == null)
				{
					_baseMaterialQuantity = (CInt32) CR2WTypeManager.Create("Int32", "BaseMaterialQuantity", cr2w, this);
				}
				return _baseMaterialQuantity;
			}
			set
			{
				if (_baseMaterialQuantity == value)
				{
					return;
				}
				_baseMaterialQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("MaterialQuantity")] 
		public CInt32 MaterialQuantity
		{
			get
			{
				if (_materialQuantity == null)
				{
					_materialQuantity = (CInt32) CR2WTypeManager.Create("Int32", "MaterialQuantity", cr2w, this);
				}
				return _materialQuantity;
			}
			set
			{
				if (_materialQuantity == value)
				{
					return;
				}
				_materialQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public MaterialTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
