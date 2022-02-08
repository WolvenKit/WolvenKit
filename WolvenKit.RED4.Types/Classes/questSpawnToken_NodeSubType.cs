using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)] 
		[RED("immediate")] 
		public CBool Immediate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
