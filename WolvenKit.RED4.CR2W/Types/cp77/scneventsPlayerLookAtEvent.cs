using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayerLookAtEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private NodeRef _nodeRef;
		private scneventsPlayerLookAtEventParams _lookAtParams;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lookAtParams")] 
		public scneventsPlayerLookAtEventParams LookAtParams
		{
			get
			{
				if (_lookAtParams == null)
				{
					_lookAtParams = (scneventsPlayerLookAtEventParams) CR2WTypeManager.Create("scneventsPlayerLookAtEventParams", "lookAtParams", cr2w, this);
				}
				return _lookAtParams;
			}
			set
			{
				if (_lookAtParams == value)
				{
					return;
				}
				_lookAtParams = value;
				PropertySet(this);
			}
		}

		public scneventsPlayerLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
