using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeactivateNetworkLinkTaskData : gameScriptTaskData
	{
		private CInt32 _linkIndex;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetProperty(ref _linkIndex);
			set => SetProperty(ref _linkIndex, value);
		}

		[Ordinal(1)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		public DeactivateNetworkLinkTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
