using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetLifePathRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _lifePathID;

		[Ordinal(1)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetProperty(ref _lifePathID);
			set => SetProperty(ref _lifePathID, value);
		}

		public questSetLifePathRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
