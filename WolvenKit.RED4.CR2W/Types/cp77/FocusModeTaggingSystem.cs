using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeTaggingSystem : gameScriptableSystem
	{
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;

		[Ordinal(0)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get
			{
				if (_playerAttachedCallbackID == null)
				{
					_playerAttachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerAttachedCallbackID", cr2w, this);
				}
				return _playerAttachedCallbackID;
			}
			set
			{
				if (_playerAttachedCallbackID == value)
				{
					return;
				}
				_playerAttachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get
			{
				if (_playerDetachedCallbackID == null)
				{
					_playerDetachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerDetachedCallbackID", cr2w, this);
				}
				return _playerDetachedCallbackID;
			}
			set
			{
				if (_playerDetachedCallbackID == value)
				{
					return;
				}
				_playerDetachedCallbackID = value;
				PropertySet(this);
			}
		}

		public FocusModeTaggingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
