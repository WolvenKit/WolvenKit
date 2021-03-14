using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackPlayerEvent : redEvent
	{
		private entEntityID _netrunnerID;
		private entEntityID _targetID;
		private wCHandle<gamedataObjectAction_Record> _objectRecord;
		private CBool _showDirectionalIndicator;

		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get
			{
				if (_netrunnerID == null)
				{
					_netrunnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "netrunnerID", cr2w, this);
				}
				return _netrunnerID;
			}
			set
			{
				if (_netrunnerID == value)
				{
					return;
				}
				_netrunnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("objectRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectRecord
		{
			get
			{
				if (_objectRecord == null)
				{
					_objectRecord = (wCHandle<gamedataObjectAction_Record>) CR2WTypeManager.Create("whandle:gamedataObjectAction_Record", "objectRecord", cr2w, this);
				}
				return _objectRecord;
			}
			set
			{
				if (_objectRecord == value)
				{
					return;
				}
				_objectRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("showDirectionalIndicator")] 
		public CBool ShowDirectionalIndicator
		{
			get
			{
				if (_showDirectionalIndicator == null)
				{
					_showDirectionalIndicator = (CBool) CR2WTypeManager.Create("Bool", "showDirectionalIndicator", cr2w, this);
				}
				return _showDirectionalIndicator;
			}
			set
			{
				if (_showDirectionalIndicator == value)
				{
					return;
				}
				_showDirectionalIndicator = value;
				PropertySet(this);
			}
		}

		public HackPlayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
