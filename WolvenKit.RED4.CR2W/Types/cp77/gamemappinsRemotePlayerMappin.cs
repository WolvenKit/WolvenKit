using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		private CBool _hasMissionData;
		private CInt32 _vitals;

		[Ordinal(0)] 
		[RED("hasMissionData")] 
		public CBool HasMissionData
		{
			get => GetProperty(ref _hasMissionData);
			set => SetProperty(ref _hasMissionData, value);
		}

		[Ordinal(1)] 
		[RED("vitals")] 
		public CInt32 Vitals
		{
			get => GetProperty(ref _vitals);
			set => SetProperty(ref _vitals, value);
		}

		public gamemappinsRemotePlayerMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
