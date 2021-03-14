using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopEntityEffectSpawnerSyncData : CVariable
	{
		private EditorObjectID _componentID;
		private EditorObjectID _componentParentID;
		private CName _componentName;
		private CArray<interopEntityEffectSelectionSyncData> _effects;
		private CString _templatePath;
		private CColor _templateColor;
		private CBool _included;

		[Ordinal(0)] 
		[RED("componentID")] 
		public EditorObjectID ComponentID
		{
			get
			{
				if (_componentID == null)
				{
					_componentID = (EditorObjectID) CR2WTypeManager.Create("EditorObjectID", "componentID", cr2w, this);
				}
				return _componentID;
			}
			set
			{
				if (_componentID == value)
				{
					return;
				}
				_componentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("componentParentID")] 
		public EditorObjectID ComponentParentID
		{
			get
			{
				if (_componentParentID == null)
				{
					_componentParentID = (EditorObjectID) CR2WTypeManager.Create("EditorObjectID", "componentParentID", cr2w, this);
				}
				return _componentParentID;
			}
			set
			{
				if (_componentParentID == value)
				{
					return;
				}
				_componentParentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effects")] 
		public CArray<interopEntityEffectSelectionSyncData> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<interopEntityEffectSelectionSyncData>) CR2WTypeManager.Create("array:interopEntityEffectSelectionSyncData", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("templatePath")] 
		public CString TemplatePath
		{
			get
			{
				if (_templatePath == null)
				{
					_templatePath = (CString) CR2WTypeManager.Create("String", "templatePath", cr2w, this);
				}
				return _templatePath;
			}
			set
			{
				if (_templatePath == value)
				{
					return;
				}
				_templatePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("templateColor")] 
		public CColor TemplateColor
		{
			get
			{
				if (_templateColor == null)
				{
					_templateColor = (CColor) CR2WTypeManager.Create("Color", "templateColor", cr2w, this);
				}
				return _templateColor;
			}
			set
			{
				if (_templateColor == value)
				{
					return;
				}
				_templateColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("included")] 
		public CBool Included
		{
			get
			{
				if (_included == null)
				{
					_included = (CBool) CR2WTypeManager.Create("Bool", "included", cr2w, this);
				}
				return _included;
			}
			set
			{
				if (_included == value)
				{
					return;
				}
				_included = value;
				PropertySet(this);
			}
		}

		public interopEntityEffectSpawnerSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
