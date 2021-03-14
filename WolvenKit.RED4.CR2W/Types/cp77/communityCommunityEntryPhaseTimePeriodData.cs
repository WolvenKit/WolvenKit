using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseTimePeriodData : CVariable
	{
		private CName _periodName;
		private CArray<worldGlobalNodeID> _spotNodeIds;
		private CBool _isSequence;

		[Ordinal(0)] 
		[RED("periodName")] 
		public CName PeriodName
		{
			get
			{
				if (_periodName == null)
				{
					_periodName = (CName) CR2WTypeManager.Create("CName", "periodName", cr2w, this);
				}
				return _periodName;
			}
			set
			{
				if (_periodName == value)
				{
					return;
				}
				_periodName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spotNodeIds")] 
		public CArray<worldGlobalNodeID> SpotNodeIds
		{
			get
			{
				if (_spotNodeIds == null)
				{
					_spotNodeIds = (CArray<worldGlobalNodeID>) CR2WTypeManager.Create("array:worldGlobalNodeID", "spotNodeIds", cr2w, this);
				}
				return _spotNodeIds;
			}
			set
			{
				if (_spotNodeIds == value)
				{
					return;
				}
				_spotNodeIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get
			{
				if (_isSequence == null)
				{
					_isSequence = (CBool) CR2WTypeManager.Create("Bool", "isSequence", cr2w, this);
				}
				return _isSequence;
			}
			set
			{
				if (_isSequence == value)
				{
					return;
				}
				_isSequence = value;
				PropertySet(this);
			}
		}

		public communityCommunityEntryPhaseTimePeriodData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
