using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterFastTravelPointsRequest : gameScriptableSystemRequest
	{
		private CArray<CHandle<gameFastTravelPointData>> _fastTravelNodes;
		private CBool _register;

		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetProperty(ref _fastTravelNodes);
			set => SetProperty(ref _fastTravelNodes, value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		public RegisterFastTravelPointsRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
