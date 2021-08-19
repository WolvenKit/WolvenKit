using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotPersistentData : CVariable
	{
		private WorldPosition _worldPosition;
		private worldGlobalNodeID _globalNodeId;
		private CFloat _yaw;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("globalNodeId")] 
		public worldGlobalNodeID GlobalNodeId
		{
			get => GetProperty(ref _globalNodeId);
			set => SetProperty(ref _globalNodeId, value);
		}

		[Ordinal(2)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public AISpotPersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
