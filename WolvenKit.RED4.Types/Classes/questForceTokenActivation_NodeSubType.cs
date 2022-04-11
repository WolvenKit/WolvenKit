using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForceTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)] 
		[RED("forceCreatingToken")] 
		public CBool ForceCreatingToken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
