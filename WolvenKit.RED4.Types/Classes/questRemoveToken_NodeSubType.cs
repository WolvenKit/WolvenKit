using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRemoveToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _removeAll;

		[Ordinal(0)] 
		[RED("removeAll")] 
		public CBool RemoveAll
		{
			get => GetProperty(ref _removeAll);
			set => SetProperty(ref _removeAll, value);
		}
	}
}
