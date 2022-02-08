using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNodeDebugState : ISerializable
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public CUInt32 NodeId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
