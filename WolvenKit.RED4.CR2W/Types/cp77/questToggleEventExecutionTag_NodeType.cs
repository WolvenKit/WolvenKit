using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleEventExecutionTag_NodeType : questISceneManagerNodeType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CName _eventExecutionTag;
		private CBool _mute;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventExecutionTag")] 
		public CName EventExecutionTag
		{
			get
			{
				if (_eventExecutionTag == null)
				{
					_eventExecutionTag = (CName) CR2WTypeManager.Create("CName", "eventExecutionTag", cr2w, this);
				}
				return _eventExecutionTag;
			}
			set
			{
				if (_eventExecutionTag == value)
				{
					return;
				}
				_eventExecutionTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mute")] 
		public CBool Mute
		{
			get
			{
				if (_mute == null)
				{
					_mute = (CBool) CR2WTypeManager.Create("Bool", "mute", cr2w, this);
				}
				return _mute;
			}
			set
			{
				if (_mute == value)
				{
					return;
				}
				_mute = value;
				PropertySet(this);
			}
		}

		public questToggleEventExecutionTag_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
