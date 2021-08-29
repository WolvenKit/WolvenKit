using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityAttachementComponent : gameScriptableComponent
	{
		private EntityAttachementData _parentAttachementData;

		[Ordinal(5)] 
		[RED("parentAttachementData")] 
		public EntityAttachementData ParentAttachementData
		{
			get => GetProperty(ref _parentAttachementData);
			set => SetProperty(ref _parentAttachementData, value);
		}
	}
}
