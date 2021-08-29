using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityAttachementRequestEvent : redEvent
	{
		private EntityAttachementData _attachementData;

		[Ordinal(0)] 
		[RED("attachementData")] 
		public EntityAttachementData AttachementData
		{
			get => GetProperty(ref _attachementData);
			set => SetProperty(ref _attachementData, value);
		}
	}
}
