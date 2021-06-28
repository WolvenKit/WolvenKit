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
			get => GetProperty(ref _highlightedDeviceID);
			set => SetProperty(ref _highlightedDeviceID, value);
		}

		[Ordinal(1)] 
		[RED("highlightedConnectionsIDs")] 
		public CArray<entEntityID> HighlightedConnectionsIDs
		{
			get => GetProperty(ref _highlightedConnectionsIDs);
			set => SetProperty(ref _highlightedConnectionsIDs, value);
		}

		public DeviceConnectionsHighlightSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
