using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimGraphDebugState : ISerializable
	{
		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<animAnimNodeDebugState> Nodes
		{
			get => GetPropertyValue<CArray<animAnimNodeDebugState>>();
			set => SetPropertyValue<CArray<animAnimNodeDebugState>>(value);
		}

		public animAnimGraphDebugState()
		{
			Nodes = new();
		}
	}
}
