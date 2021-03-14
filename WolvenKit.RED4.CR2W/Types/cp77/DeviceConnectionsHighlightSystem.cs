using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		private entEntityID _highlightedDeviceID;
		private CArray<entEntityID> _highlightedConnectionsIDs;

		[Ordinal(0)] 
		[RED("highlightedDeviceID")] 
		public entEntityID HighlightedDeviceID
		{
			get
			{
				if (_highlightedDeviceID == null)
				{
					_highlightedDeviceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "highlightedDeviceID", cr2w, this);
				}
				return _highlightedDeviceID;
			}
			set
			{
				if (_highlightedDeviceID == value)
				{
					return;
				}
				_highlightedDeviceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highlightedConnectionsIDs")] 
		public CArray<entEntityID> HighlightedConnectionsIDs
		{
			get
			{
				if (_highlightedConnectionsIDs == null)
				{
					_highlightedConnectionsIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "highlightedConnectionsIDs", cr2w, this);
				}
				return _highlightedConnectionsIDs;
			}
			set
			{
				if (_highlightedConnectionsIDs == value)
				{
					return;
				}
				_highlightedConnectionsIDs = value;
				PropertySet(this);
			}
		}

		public DeviceConnectionsHighlightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
