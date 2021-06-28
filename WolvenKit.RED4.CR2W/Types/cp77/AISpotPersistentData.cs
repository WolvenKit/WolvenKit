using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotPersistentData : CVariable
	{
		private WorldTransform _worldTransform;
		private worldGlobalNodeID _globalNodeId;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get => GetProperty(ref _worldTransform);
			set => SetProperty(ref _worldTransform, value);
		}

		[Ordinal(1)] 
		[RED("globalNodeId")] 
		public worldGlobalNodeID GlobalNodeId
		{
			get => GetProperty(ref _globalNodeId);
			set => SetProperty(ref _globalNodeId, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public AISpotPersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
