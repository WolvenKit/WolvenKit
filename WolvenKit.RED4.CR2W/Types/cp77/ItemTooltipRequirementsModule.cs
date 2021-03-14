using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _levelRequirementsWrapper;
		private inkWidgetReference _strenghtOrReflexWrapper;
		private inkWidgetReference _smartlinkGunWrapper;
		private inkWidgetReference _anyAttributeWrapper;
		private inkTextWidgetReference _levelRequirementsText;
		private inkTextWidgetReference _strenghtOrReflexText;
		private inkTextWidgetReference _anyAttributeText;

		[Ordinal(2)] 
		[RED("levelRequirementsWrapper")] 
		public inkWidgetReference LevelRequirementsWrapper
		{
			get
			{
				if (_levelRequirementsWrapper == null)
				{
					_levelRequirementsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelRequirementsWrapper", cr2w, this);
				}
				return _levelRequirementsWrapper;
			}
			set
			{
				if (_levelRequirementsWrapper == value)
				{
					return;
				}
				_levelRequirementsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("strenghtOrReflexWrapper")] 
		public inkWidgetReference StrenghtOrReflexWrapper
		{
			get
			{
				if (_strenghtOrReflexWrapper == null)
				{
					_strenghtOrReflexWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "strenghtOrReflexWrapper", cr2w, this);
				}
				return _strenghtOrReflexWrapper;
			}
			set
			{
				if (_strenghtOrReflexWrapper == value)
				{
					return;
				}
				_strenghtOrReflexWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get
			{
				if (_smartlinkGunWrapper == null)
				{
					_smartlinkGunWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "smartlinkGunWrapper", cr2w, this);
				}
				return _smartlinkGunWrapper;
			}
			set
			{
				if (_smartlinkGunWrapper == value)
				{
					return;
				}
				_smartlinkGunWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("anyAttributeWrapper")] 
		public inkWidgetReference AnyAttributeWrapper
		{
			get
			{
				if (_anyAttributeWrapper == null)
				{
					_anyAttributeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "anyAttributeWrapper", cr2w, this);
				}
				return _anyAttributeWrapper;
			}
			set
			{
				if (_anyAttributeWrapper == value)
				{
					return;
				}
				_anyAttributeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("levelRequirementsText")] 
		public inkTextWidgetReference LevelRequirementsText
		{
			get
			{
				if (_levelRequirementsText == null)
				{
					_levelRequirementsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelRequirementsText", cr2w, this);
				}
				return _levelRequirementsText;
			}
			set
			{
				if (_levelRequirementsText == value)
				{
					return;
				}
				_levelRequirementsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("strenghtOrReflexText")] 
		public inkTextWidgetReference StrenghtOrReflexText
		{
			get
			{
				if (_strenghtOrReflexText == null)
				{
					_strenghtOrReflexText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "strenghtOrReflexText", cr2w, this);
				}
				return _strenghtOrReflexText;
			}
			set
			{
				if (_strenghtOrReflexText == value)
				{
					return;
				}
				_strenghtOrReflexText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("anyAttributeText")] 
		public inkTextWidgetReference AnyAttributeText
		{
			get
			{
				if (_anyAttributeText == null)
				{
					_anyAttributeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "anyAttributeText", cr2w, this);
				}
				return _anyAttributeText;
			}
			set
			{
				if (_anyAttributeText == value)
				{
					return;
				}
				_anyAttributeText = value;
				PropertySet(this);
			}
		}

		public ItemTooltipRequirementsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
