using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopEntityEffectSpawnerSyncData : RedBaseClass
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
			get => GetProperty(ref _componentID);
			set => SetProperty(ref _componentID, value);
		}

		[Ordinal(1)] 
		[RED("componentParentID")] 
		public EditorObjectID ComponentParentID
		{
			get => GetProperty(ref _componentParentID);
			set => SetProperty(ref _componentParentID, value);
		}

		[Ordinal(2)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(3)] 
		[RED("effects")] 
		public CArray<interopEntityEffectSelectionSyncData> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(4)] 
		[RED("templatePath")] 
		public CString TemplatePath
		{
			get => GetProperty(ref _templatePath);
			set => SetProperty(ref _templatePath, value);
		}

		[Ordinal(5)] 
		[RED("templateColor")] 
		public CColor TemplateColor
		{
			get => GetProperty(ref _templateColor);
			set => SetProperty(ref _templateColor, value);
		}

		[Ordinal(6)] 
		[RED("included")] 
		public CBool Included
		{
			get => GetProperty(ref _included);
			set => SetProperty(ref _included, value);
		}
	}
}
