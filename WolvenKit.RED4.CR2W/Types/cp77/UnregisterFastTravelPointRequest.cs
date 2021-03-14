using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterFastTravelPointRequest : gameScriptableSystemRequest
	{
		private CHandle<gameFastTravelPointData> _pointData;
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("pointData")] 
		public CHandle<gameFastTravelPointData> PointData
		{
			get
			{
				if (_pointData == null)
				{
					_pointData = (CHandle<gameFastTravelPointData>) CR2WTypeManager.Create("handle:gameFastTravelPointData", "pointData", cr2w, this);
				}
				return _pointData;
			}
			set
			{
				if (_pointData == value)
				{
					return;
				}
				_pointData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public UnregisterFastTravelPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
