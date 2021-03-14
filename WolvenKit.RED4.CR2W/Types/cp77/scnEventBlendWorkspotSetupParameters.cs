using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEventBlendWorkspotSetupParameters : ISerializable
	{
		private scnSceneWorkspotInstanceId _workspotId;
		private workWorkEntryId _sequenceEntryId;
		private CBool _idleOnlyMode;
		private CArray<workWorkEntryId> _workExcludedGestures;
		private workWorkspotItemOverride _itemOverride;

		[Ordinal(0)] 
		[RED("workspotId")] 
		public scnSceneWorkspotInstanceId WorkspotId
		{
			get
			{
				if (_workspotId == null)
				{
					_workspotId = (scnSceneWorkspotInstanceId) CR2WTypeManager.Create("scnSceneWorkspotInstanceId", "workspotId", cr2w, this);
				}
				return _workspotId;
			}
			set
			{
				if (_workspotId == value)
				{
					return;
				}
				_workspotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sequenceEntryId")] 
		public workWorkEntryId SequenceEntryId
		{
			get
			{
				if (_sequenceEntryId == null)
				{
					_sequenceEntryId = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "sequenceEntryId", cr2w, this);
				}
				return _sequenceEntryId;
			}
			set
			{
				if (_sequenceEntryId == value)
				{
					return;
				}
				_sequenceEntryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get
			{
				if (_idleOnlyMode == null)
				{
					_idleOnlyMode = (CBool) CR2WTypeManager.Create("Bool", "idleOnlyMode", cr2w, this);
				}
				return _idleOnlyMode;
			}
			set
			{
				if (_idleOnlyMode == value)
				{
					return;
				}
				_idleOnlyMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get
			{
				if (_workExcludedGestures == null)
				{
					_workExcludedGestures = (CArray<workWorkEntryId>) CR2WTypeManager.Create("array:workWorkEntryId", "workExcludedGestures", cr2w, this);
				}
				return _workExcludedGestures;
			}
			set
			{
				if (_workExcludedGestures == value)
				{
					return;
				}
				_workExcludedGestures = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get
			{
				if (_itemOverride == null)
				{
					_itemOverride = (workWorkspotItemOverride) CR2WTypeManager.Create("workWorkspotItemOverride", "itemOverride", cr2w, this);
				}
				return _itemOverride;
			}
			set
			{
				if (_itemOverride == value)
				{
					return;
				}
				_itemOverride = value;
				PropertySet(this);
			}
		}

		public scnEventBlendWorkspotSetupParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
