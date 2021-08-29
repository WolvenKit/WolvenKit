using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _immediate;

		[Ordinal(0)] 
		[RED("immediate")] 
		public CBool Immediate
		{
			get => GetProperty(ref _immediate);
			set => SetProperty(ref _immediate, value);
		}
	}
}
