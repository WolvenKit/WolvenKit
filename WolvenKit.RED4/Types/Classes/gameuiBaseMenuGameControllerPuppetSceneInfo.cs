using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseMenuGameControllerPuppetSceneInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("entityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> EntityTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(4)] 
		[RED("puppetRecordId")] 
		public TweakDBID PuppetRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("gender")] 
		public CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> Gender
		{
			get => GetPropertyValue<CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo>>();
			set => SetPropertyValue<CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo>>(value);
		}

		public gameuiBaseMenuGameControllerPuppetSceneInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
