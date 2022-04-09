using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopEntityEffectSelectionSyncData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("effectIDPath")] 
		public toolsEditorObjectIDPath EffectIDPath
		{
			get => GetPropertyValue<toolsEditorObjectIDPath>();
			set => SetPropertyValue<toolsEditorObjectIDPath>(value);
		}

		public interopEntityEffectSelectionSyncData()
		{
			EffectIDPath = new() { Elements = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
