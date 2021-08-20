using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateLinksRequest : gameScriptableSystemRequest
	{
		private CArray<CInt32> _linksIDs;

		[Ordinal(0)] 
		[RED("linksIDs")] 
		public CArray<CInt32> LinksIDs
		{
			get => GetProperty(ref _linksIDs);
			set => SetProperty(ref _linksIDs, value);
		}

		public ActivateLinksRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
