using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerManageBinkComponent_NodeTypeParams : CVariable
	{
		private gameEntityReference _objectRef;
		private CString _videoPath;
		private CEnum<gameBinkVideoAction> _action;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (CString) CR2WTypeManager.Create("String", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<gameBinkVideoAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gameBinkVideoAction>) CR2WTypeManager.Create("gameBinkVideoAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public questEntityManagerManageBinkComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
