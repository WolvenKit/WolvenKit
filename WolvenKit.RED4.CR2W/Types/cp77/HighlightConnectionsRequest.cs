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
			get
			{
				if (_shouldHighlight == null)
				{
					_shouldHighlight = (CBool) CR2WTypeManager.Create("Bool", "shouldHighlight", cr2w, this);
				}
				return _shouldHighlight;
			}
			set
			{
				if (_shouldHighlight == value)
				{
					return;
				}
				_shouldHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isTriggeredByMasterDevice")] 
		public CBool IsTriggeredByMasterDevice
		{
			get
			{
				if (_isTriggeredByMasterDevice == null)
				{
					_isTriggeredByMasterDevice = (CBool) CR2WTypeManager.Create("Bool", "isTriggeredByMasterDevice", cr2w, this);
				}
				return _isTriggeredByMasterDevice;
			}
			set
			{
				if (_isTriggeredByMasterDevice == value)
				{
					return;
				}
				_isTriggeredByMasterDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("highlightTargets")] 
		public CArray<NodeRef> HighlightTargets
		{
			get
			{
				if (_highlightTargets == null)
				{
					_highlightTargets = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "highlightTargets", cr2w, this);
				}
				return _highlightTargets;
			}
			set
			{
				if (_highlightTargets == value)
				{
					return;
				}
				_highlightTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("requestingDevice")] 
		public entEntityID RequestingDevice
		{
			get
			{
				if (_requestingDevice == null)
				{
					_requestingDevice = (entEntityID) CR2WTypeManager.Create("entEntityID", "requestingDevice", cr2w, this);
				}
				return _requestingDevice;
			}
			set
			{
				if (_requestingDevice == value)
				{
					return;
				}
				_requestingDevice = value;
				PropertySet(this);
			}
		}

		public HighlightConnectionsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
