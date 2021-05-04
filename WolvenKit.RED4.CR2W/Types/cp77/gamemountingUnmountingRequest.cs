using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingUnmountingRequest : IScriptable
	{
		private gamemountingMountingInfo _lowLevelMountingInfo;
		private CHandle<gameMountEventData> _mountData;

		[Ordinal(0)] 
		[RED("lowLevelMountingInfo")] 
		public gamemountingMountingInfo LowLevelMountingInfo
		{
			get => GetProperty(ref _lowLevelMountingInfo);
			set => SetProperty(ref _lowLevelMountingInfo, value);
		}

		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		public gamemountingUnmountingRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
