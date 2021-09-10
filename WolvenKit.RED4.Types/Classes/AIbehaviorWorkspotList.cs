using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorWorkspotList : IScriptable
	{
		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<NodeRef> Spots
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public AIbehaviorWorkspotList()
		{
			Spots = new();
		}
	}
}
