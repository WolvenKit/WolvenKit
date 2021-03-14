using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotFinishedEvent : redEvent
	{
		private worldGlobalNodeID _nodeId;
		private CArray<CName> _tags;
		private TweakDBID _statusEffectID;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public worldGlobalNodeID NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectID", cr2w, this);
				}
				return _statusEffectID;
			}
			set
			{
				if (_statusEffectID == value)
				{
					return;
				}
				_statusEffectID = value;
				PropertySet(this);
			}
		}

		public workWorkspotFinishedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
