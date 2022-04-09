using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AccessBreach : PuppetAction
	{
		[Ordinal(25)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(27)] 
		[RED("npcCount")] 
		public CInt32 NpcCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("isSuicide")] 
		public CBool IsSuicide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AccessBreach()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
