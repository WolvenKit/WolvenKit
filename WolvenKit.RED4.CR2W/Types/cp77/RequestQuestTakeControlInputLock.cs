using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestQuestTakeControlInputLock : gameScriptableSystemRequest
	{
		private CBool _isLocked;
		private CBool _isChainForced;

		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isChainForced")] 
		public CBool IsChainForced
		{
			get
			{
				if (_isChainForced == null)
				{
					_isChainForced = (CBool) CR2WTypeManager.Create("Bool", "isChainForced", cr2w, this);
				}
				return _isChainForced;
			}
			set
			{
				if (_isChainForced == value)
				{
					return;
				}
				_isChainForced = value;
				PropertySet(this);
			}
		}

		public RequestQuestTakeControlInputLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
