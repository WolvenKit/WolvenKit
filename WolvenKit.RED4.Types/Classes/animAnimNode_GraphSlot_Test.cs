using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_GraphSlot_Test : animAnimNode_GraphSlot
	{
		[Ordinal(14)] 
		[RED("graph_TEST")] 
		public CResourceReference<animAnimGraph> Graph_TEST
		{
			get => GetPropertyValue<CResourceReference<animAnimGraph>>();
			set => SetPropertyValue<CResourceReference<animAnimGraph>>(value);
		}
	}
}
