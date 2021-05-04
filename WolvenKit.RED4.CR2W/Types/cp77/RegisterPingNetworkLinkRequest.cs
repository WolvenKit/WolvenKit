using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPingNetworkLinkRequest : gameScriptableSystemRequest
	{
		private CArray<SNetworkLinkData> _linksData;

		[Ordinal(0)] 
		[RED("linksData")] 
		public CArray<SNetworkLinkData> LinksData
		{
			get => GetProperty(ref _linksData);
			set => SetProperty(ref _linksData, value);
		}

		public RegisterPingNetworkLinkRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
