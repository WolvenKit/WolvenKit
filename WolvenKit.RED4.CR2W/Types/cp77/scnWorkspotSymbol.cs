using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotSymbol : CVariable
	{
		private scnSceneWorkspotInstanceId _wsInstance;
		private scnNodeId _wsNodeId;
		private CUInt64 _wsEditorEventId;

		[Ordinal(0)] 
		[RED("wsInstance")] 
		public scnSceneWorkspotInstanceId WsInstance
		{
			get
			{
				if (_wsInstance == null)
				{
					_wsInstance = (scnSceneWorkspotInstanceId) CR2WTypeManager.Create("scnSceneWorkspotInstanceId", "wsInstance", cr2w, this);
				}
				return _wsInstance;
			}
			set
			{
				if (_wsInstance == value)
				{
					return;
				}
				_wsInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wsNodeId")] 
		public scnNodeId WsNodeId
		{
			get
			{
				if (_wsNodeId == null)
				{
					_wsNodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "wsNodeId", cr2w, this);
				}
				return _wsNodeId;
			}
			set
			{
				if (_wsNodeId == value)
				{
					return;
				}
				_wsNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wsEditorEventId")] 
		public CUInt64 WsEditorEventId
		{
			get
			{
				if (_wsEditorEventId == null)
				{
					_wsEditorEventId = (CUInt64) CR2WTypeManager.Create("Uint64", "wsEditorEventId", cr2w, this);
				}
				return _wsEditorEventId;
			}
			set
			{
				if (_wsEditorEventId == value)
				{
					return;
				}
				_wsEditorEventId = value;
				PropertySet(this);
			}
		}

		public scnWorkspotSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
