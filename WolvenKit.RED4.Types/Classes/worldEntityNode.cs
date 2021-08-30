using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEntityNode : worldNode
	{
		private CResourceAsyncReference<entEntityTemplate> _entityTemplate;
		private CHandle<entEntityInstanceData> _instanceData;
		private CName _appearanceName;
		private CEnum<entEntitySpawnPriority> _ioPriority;
		private CUInt16 _entityLod;

		[Ordinal(4)] 
		[RED("entityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> EntityTemplate
		{
			get => GetProperty(ref _entityTemplate);
			set => SetProperty(ref _entityTemplate, value);
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<entEntityInstanceData> InstanceData
		{
			get => GetProperty(ref _instanceData);
			set => SetProperty(ref _instanceData, value);
		}

		[Ordinal(6)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(7)] 
		[RED("ioPriority")] 
		public CEnum<entEntitySpawnPriority> IoPriority
		{
			get => GetProperty(ref _ioPriority);
			set => SetProperty(ref _ioPriority, value);
		}

		[Ordinal(8)] 
		[RED("entityLod")] 
		public CUInt16 EntityLod
		{
			get => GetProperty(ref _entityLod);
			set => SetProperty(ref _entityLod, value);
		}

		public worldEntityNode()
		{
			_appearanceName = "default";
			_ioPriority = new() { Value = Enums.entEntitySpawnPriority.Immediate };
		}
	}
}
