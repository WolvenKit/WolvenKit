using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		private LinkedFocusClueData _linkedCluekData;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		public UnregisterLinkedCluekRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
