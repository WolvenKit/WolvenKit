using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopEntityEffectSpawnerSyncData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentID")] 
		public EditorObjectID ComponentID
		{
			get => GetPropertyValue<EditorObjectID>();
			set => SetPropertyValue<EditorObjectID>(value);
		}

		[Ordinal(1)] 
		[RED("componentParentID")] 
		public EditorObjectID ComponentParentID
		{
			get => GetPropertyValue<EditorObjectID>();
			set => SetPropertyValue<EditorObjectID>(value);
		}

		[Ordinal(2)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("effects")] 
		public CArray<interopEntityEffectSelectionSyncData> Effects
		{
			get => GetPropertyValue<CArray<interopEntityEffectSelectionSyncData>>();
			set => SetPropertyValue<CArray<interopEntityEffectSelectionSyncData>>(value);
		}

		[Ordinal(4)] 
		[RED("templatePath")] 
		public CString TemplatePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("templateColor")] 
		public CColor TemplateColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("included")] 
		public CBool Included
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public interopEntityEffectSpawnerSyncData()
		{
			Effects = new();
			TemplateColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
