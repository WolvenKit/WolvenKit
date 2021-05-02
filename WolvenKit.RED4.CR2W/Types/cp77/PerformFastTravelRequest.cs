using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerformFastTravelRequest : gameScriptableSystemRequest
	{
		private CHandle<gameFastTravelPointData> _pointData;
		private wCHandle<gameObject> _player;

		[Ordinal(0)] 
		[RED("pointData")] 
		public CHandle<gameFastTravelPointData> PointData
		{
			get => GetProperty(ref _pointData);
			set => SetProperty(ref _pointData, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public PerformFastTravelRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
