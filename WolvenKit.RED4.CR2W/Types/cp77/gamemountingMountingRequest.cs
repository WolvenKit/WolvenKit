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
			get => GetProperty(ref _lowLevelMountingInfo);
			set => SetProperty(ref _lowLevelMountingInfo, value);
		}

		[Ordinal(1)] 
		[RED("preservePositionAfterMounting")] 
		public CBool PreservePositionAfterMounting
		{
			get => GetProperty(ref _preservePositionAfterMounting);
			set => SetProperty(ref _preservePositionAfterMounting, value);
		}

		[Ordinal(2)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		public gamemountingMountingRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
