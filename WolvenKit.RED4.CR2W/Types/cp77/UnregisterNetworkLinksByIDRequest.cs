using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinksByIDRequest : gameScriptableSystemRequest
	{
		private entEntityID _iD;

		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		public UnregisterNetworkLinksByIDRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
