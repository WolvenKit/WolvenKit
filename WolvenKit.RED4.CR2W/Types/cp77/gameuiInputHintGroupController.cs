using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleTextRef;
		private inkTextWidgetReference _descriptionTextRef;
		private inkCompoundWidgetReference _hintsContainerRef;
		private inkImageWidgetReference _iconRef;

		[Ordinal(1)] 
		[RED("titleTextRef")] 
		public inkTextWidgetReference TitleTextRef
		{
			get
			{
				if (_titleTextRef == null)
				{
					_titleTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleTextRef", cr2w, this);
				}
				return _titleTextRef;
			}
			set
			{
				if (_titleTextRef == value)
				{
					return;
				}
				_titleTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("descriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get
			{
				if (_descriptionTextRef == null)
				{
					_descriptionTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionTextRef", cr2w, this);
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
		[RED("hintsContainerRef")] 
		public inkCompoundWidgetReference HintsContainerRef
		{
			get
			{
				if (_hintsContainerRef == null)
				{
					_hintsContainerRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "hintsContainerRef", cr2w, this);
				}
				return _hintsContainerRef;
			}
			set
			{
				if (_hintsContainerRef == value)
				{
					return;
				}
				_hintsContainerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get
			{
				if (_iconRef == null)
				{
					_iconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconRef", cr2w, this);
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

		public gameuiInputHintGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
