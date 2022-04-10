using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEntityNode : worldNode
	{
		[Ordinal(4)] 
		[RED("entityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> EntityTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<entEntityInstanceData> InstanceData
		{
			get => GetPropertyValue<CHandle<entEntityInstanceData>>();
			set => SetPropertyValue<CHandle<entEntityInstanceData>>(value);
		}

		[Ordinal(6)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("ioPriority")] 
		public CEnum<entEntitySpawnPriority> IoPriority
		{
			get => GetPropertyValue<CEnum<entEntitySpawnPriority>>();
			set => SetPropertyValue<CEnum<entEntitySpawnPriority>>(value);
		}

		[Ordinal(8)] 
		[RED("entityLod")] 
		public CUInt16 EntityLod
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public worldEntityNode()
		{
			AppearanceName = "default";
			IoPriority = Enums.entEntitySpawnPriority.Immediate;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
