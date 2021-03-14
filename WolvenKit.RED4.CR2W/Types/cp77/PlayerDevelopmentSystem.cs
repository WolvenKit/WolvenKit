using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<PlayerDevelopmentData>> _playerData;
		private CArray<CHandle<PlayerDevelopmentData>> _ownerData;

		[Ordinal(0)] 
		[RED("playerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> PlayerData
		{
			get
			{
				if (_playerData == null)
				{
					_playerData = (CArray<CHandle<PlayerDevelopmentData>>) CR2WTypeManager.Create("array:handle:PlayerDevelopmentData", "playerData", cr2w, this);
				}
				return _playerData;
			}
			set
			{
				if (_playerData == value)
				{
					return;
				}
				_playerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerData")] 
		public CArray<CHandle<PlayerDevelopmentData>> OwnerData
		{
			get
			{
				if (_ownerData == null)
				{
					_ownerData = (CArray<CHandle<PlayerDevelopmentData>>) CR2WTypeManager.Create("array:handle:PlayerDevelopmentData", "ownerData", cr2w, this);
				}
				return _ownerData;
			}
			set
			{
				if (_ownerData == value)
				{
					return;
				}
				_ownerData = value;
				PropertySet(this);
			}
		}

		public PlayerDevelopmentSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
