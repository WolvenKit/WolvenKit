using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HighlightConnectionsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("shouldHighlight")] 
		public CBool ShouldHighlight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isTriggeredByMasterDevice")] 
		public CBool IsTriggeredByMasterDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("highlightTargets")] 
		public CArray<NodeRef> HighlightTargets
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(3)] 
		[RED("requestingDevice")] 
		public entEntityID RequestingDevice
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public HighlightConnectionsRequest()
		{
			HighlightTargets = new();
			RequestingDevice = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
