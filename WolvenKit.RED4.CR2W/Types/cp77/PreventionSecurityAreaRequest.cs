using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		private CBool _playerIsIn;
		private gamePersistentID _areaID;

		[Ordinal(0)] 
		[RED("playerIsIn")] 
		public CBool PlayerIsIn
		{
			get
			{
				if (_playerIsIn == null)
				{
					_playerIsIn = (CBool) CR2WTypeManager.Create("Bool", "playerIsIn", cr2w, this);
				}
				return _playerIsIn;
			}
			set
			{
				if (_playerIsIn == value)
				{
					return;
				}
				_playerIsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public gamePersistentID AreaID
		{
			get
			{
				if (_areaID == null)
				{
					_areaID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "areaID", cr2w, this);
				}
				return _areaID;
			}
			set
			{
				if (_areaID == value)
				{
					return;
				}
				_areaID = value;
				PropertySet(this);
			}
		}

		public PreventionSecurityAreaRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
