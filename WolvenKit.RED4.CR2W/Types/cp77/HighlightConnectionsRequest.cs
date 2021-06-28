using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightConnectionsRequest : gameScriptableSystemRequest
	{
		private CBool _shouldHighlight;
		private CBool _isTriggeredByMasterDevice;
		private CArray<NodeRef> _highlightTargets;
		private entEntityID _requestingDevice;

		[Ordinal(0)] 
		[RED("shouldHighlight")] 
		public CBool ShouldHighlight
		{
			get => GetProperty(ref _shouldHighlight);
			set => SetProperty(ref _shouldHighlight, value);
		}

		[Ordinal(1)] 
		[RED("isTriggeredByMasterDevice")] 
		public CBool IsTriggeredByMasterDevice
		{
			get => GetProperty(ref _isTriggeredByMasterDevice);
			set => SetProperty(ref _isTriggeredByMasterDevice, value);
		}

		[Ordinal(2)] 
		[RED("highlightTargets")] 
		public CArray<NodeRef> HighlightTargets
		{
			get => GetProperty(ref _highlightTargets);
			set => SetProperty(ref _highlightTargets, value);
		}

		[Ordinal(3)] 
		[RED("requestingDevice")] 
		public entEntityID RequestingDevice
		{
			get => GetProperty(ref _requestingDevice);
			set => SetProperty(ref _requestingDevice, value);
		}

		public HighlightConnectionsRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
