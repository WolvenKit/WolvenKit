using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMenuEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("menuWidget")] 
		public CResourceReference<inkWidgetLibraryResource> MenuWidget
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("spawnMode")] 
		public CEnum<inkSpawnMode> SpawnMode
		{
			get => GetPropertyValue<CEnum<inkSpawnMode>>();
			set => SetPropertyValue<CEnum<inkSpawnMode>>(value);
		}

		[Ordinal(4)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("inputContext")] 
		public CName InputContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkMenuEntry()
		{
			IsAffectedByFadeout = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
