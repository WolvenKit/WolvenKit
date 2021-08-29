using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshFloorDataEvent : redEvent
	{
		private CBool _passToEntity;

		[Ordinal(0)] 
		[RED("passToEntity")] 
		public CBool PassToEntity
		{
			get => GetProperty(ref _passToEntity);
			set => SetProperty(ref _passToEntity, value);
		}
	}
}
