using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameDataShapeEntry : CVariable
	{
		private WorldTransform _ansformWS;

		[Ordinal(0)] 
		[RED("ansformWS")] 
		public WorldTransform AnsformWS
		{
			get => GetProperty(ref _ansformWS);
			set => SetProperty(ref _ansformWS, value);
		}

		public gameHitDetectionDebugFrameDataShapeEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
