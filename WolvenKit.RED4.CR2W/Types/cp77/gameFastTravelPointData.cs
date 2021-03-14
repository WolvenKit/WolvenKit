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
			get
			{
				if (_pointRecord == null)
				{
					_pointRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "pointRecord", cr2w, this);
				}
				return _pointRecord;
			}
			set
			{
				if (_pointRecord == value)
				{
					return;
				}
				_pointRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get
			{
				if (_markerRef == null)
				{
					_markerRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "markerRef", cr2w, this);
				}
				return _markerRef;
			}
			set
			{
				if (_markerRef == value)
				{
					return;
				}
				_markerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requesterID", cr2w, this);
				}
				return _requesterID;
			}
			set
			{
				if (_requesterID == value)
				{
					return;
				}
				_requesterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get
			{
				if (_mappinID == null)
				{
					_mappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mappinID", cr2w, this);
				}
				return _mappinID;
			}
			set
			{
				if (_mappinID == value)
				{
					return;
				}
				_mappinID = value;
				PropertySet(this);
			}
		}

		public gameFastTravelPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
