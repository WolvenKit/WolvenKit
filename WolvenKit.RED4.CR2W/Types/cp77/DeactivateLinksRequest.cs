using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeactivateLinksRequest : gameScriptableSystemRequest
	{
		private CArray<CInt32> _linksIDs;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetProperty(ref _linksIDs);
			set => SetProperty(ref _linksIDs, value);
		}

		[Ordinal(1)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		public DeactivateLinksRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
