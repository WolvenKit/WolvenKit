using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJumpWorkspotAnim_NodeType : questIBehaviourManager_NodeType
	{
		[Ordinal(1)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("entryIdToJumpTo")] 
		public CInt32 EntryIdToJumpTo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public questJumpWorkspotAnim_NodeType()
		{
			PuppetRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
