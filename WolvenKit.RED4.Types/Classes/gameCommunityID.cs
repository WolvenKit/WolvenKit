using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCommunityID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameCommunityID()
		{
			EntityId = new();
		}
	}
}
