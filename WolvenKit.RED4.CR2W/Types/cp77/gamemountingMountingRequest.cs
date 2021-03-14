using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingRequest : IScriptable
	{
		private gamemountingMountingInfo _lowLevelMountingInfo;
		private CBool _preservePositionAfterMounting;
		private CHandle<gameMountEventData> _mountData;

		[Ordinal(0)] 
		[RED("lowLevelMountingInfo")] 
		public gamemountingMountingInfo LowLevelMountingInfo
		{
			get
			{
				if (_lowLevelMountingInfo == null)
				{
					_lowLevelMountingInfo = (gamemountingMountingInfo) CR2WTypeManager.Create("gamemountingMountingInfo", "lowLevelMountingInfo", cr2w, this);
				}
				return _lowLevelMountingInfo;
			}
			set
			{
				if (_lowLevelMountingInfo == value)
				{
					return;
				}
				_lowLevelMountingInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("preservePositionAfterMounting")] 
		public CBool PreservePositionAfterMounting
		{
			get
			{
				if (_preservePositionAfterMounting == null)
				{
					_preservePositionAfterMounting = (CBool) CR2WTypeManager.Create("Bool", "preservePositionAfterMounting", cr2w, this);
				}
				return _preservePositionAfterMounting;
			}
			set
			{
				if (_preservePositionAfterMounting == value)
				{
					return;
				}
				_preservePositionAfterMounting = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		public gamemountingMountingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
