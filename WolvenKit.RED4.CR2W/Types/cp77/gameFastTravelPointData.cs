using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFastTravelPointData : IScriptable
	{
		private TweakDBID _pointRecord;
		private NodeRef _markerRef;
		private entEntityID _requesterID;
		private gameNewMappinID _mappinID;

		[Ordinal(0)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get => GetProperty(ref _pointRecord);
			set => SetProperty(ref _pointRecord, value);
		}

		[Ordinal(1)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetProperty(ref _markerRef);
			set => SetProperty(ref _markerRef, value);
		}

		[Ordinal(2)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(3)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		public gameFastTravelPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
