using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateNetworkLinkTaskData : gameScriptTaskData
	{
		private CInt32 _linkIndex;

		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetProperty(ref _linkIndex);
			set => SetProperty(ref _linkIndex, value);
		}

		public ActivateNetworkLinkTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
