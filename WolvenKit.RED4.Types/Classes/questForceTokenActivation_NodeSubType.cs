using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForceTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _forceCreatingToken;

		[Ordinal(0)] 
		[RED("forceCreatingToken")] 
		public CBool ForceCreatingToken
		{
			get => GetProperty(ref _forceCreatingToken);
			set => SetProperty(ref _forceCreatingToken, value);
		}
	}
}
