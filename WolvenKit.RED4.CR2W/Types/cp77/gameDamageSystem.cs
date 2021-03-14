using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystem : gameIDamageSystem
	{
		private previewTargetStruct _previewTarget;
		private CBool _previewLock;
		private ScriptReentrantRWLock _previewRWLockTemp;

		[Ordinal(0)] 
		[RED("previewTarget")] 
		public previewTargetStruct PreviewTarget
		{
			get
			{
				if (_previewTarget == null)
				{
					_previewTarget = (previewTargetStruct) CR2WTypeManager.Create("previewTargetStruct", "previewTarget", cr2w, this);
				}
				return _previewTarget;
			}
			set
			{
				if (_previewTarget == value)
				{
					return;
				}
				_previewTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("previewLock")] 
		public CBool PreviewLock
		{
			get
			{
				if (_previewLock == null)
				{
					_previewLock = (CBool) CR2WTypeManager.Create("Bool", "previewLock", cr2w, this);
				}
				return _previewLock;
			}
			set
			{
				if (_previewLock == value)
				{
					return;
				}
				_previewLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previewRWLockTemp")] 
		public ScriptReentrantRWLock PreviewRWLockTemp
		{
			get
			{
				if (_previewRWLockTemp == null)
				{
					_previewRWLockTemp = (ScriptReentrantRWLock) CR2WTypeManager.Create("ScriptReentrantRWLock", "previewRWLockTemp", cr2w, this);
				}
				return _previewRWLockTemp;
			}
			set
			{
				if (_previewRWLockTemp == value)
				{
					return;
				}
				_previewRWLockTemp = value;
				PropertySet(this);
			}
		}

		public gameDamageSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
