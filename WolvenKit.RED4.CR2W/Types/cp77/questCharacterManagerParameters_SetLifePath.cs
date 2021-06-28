using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetLifePath : questICharacterManagerParameters_NodeSubType
	{
		private TweakDBID _lifePathID;

		[Ordinal(0)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetProperty(ref _lifePathID);
			set => SetProperty(ref _lifePathID, value);
		}

		public questCharacterManagerParameters_SetLifePath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
