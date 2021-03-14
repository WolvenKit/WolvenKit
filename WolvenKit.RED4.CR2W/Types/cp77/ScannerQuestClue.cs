using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuestClue : inkWidgetLogicController
	{
		private inkTextWidgetReference _categoryTextRef;
		private inkTextWidgetReference _descriptionTextRef;
		private inkImageWidgetReference _iconRef;

		[Ordinal(1)] 
		[RED("CategoryTextRef")] 
		public inkTextWidgetReference CategoryTextRef
		{
			get
			{
				if (_categoryTextRef == null)
				{
					_categoryTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CategoryTextRef", cr2w, this);
				}
				return _categoryTextRef;
			}
			set
			{
				if (_categoryTextRef == value)
				{
					return;
				}
				_categoryTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DescriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get
			{
				if (_descriptionTextRef == null)
				{
					_descriptionTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DescriptionTextRef", cr2w, this);
				}
				return _descriptionTextRef;
			}
			set
			{
				if (_descriptionTextRef == value)
				{
					return;
				}
				_descriptionTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("IconRef")] 
		public inkImageWidgetReference IconRef
		{
			get
			{
				if (_iconRef == null)
				{
					_iconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconRef", cr2w, this);
				}
				return _iconRef;
			}
			set
			{
				if (_iconRef == value)
				{
					return;
				}
				_iconRef = value;
				PropertySet(this);
			}
		}

		public ScannerQuestClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
