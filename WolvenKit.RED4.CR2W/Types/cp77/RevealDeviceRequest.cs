using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDeviceRequest : redEvent
	{
		private CBool _shouldReveal;
		private entEntityID _sourceID;
		private SNetworkLinkData _linkData;

		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetProperty(ref _shouldReveal);
			set => SetProperty(ref _shouldReveal, value);
		}

		[Ordinal(1)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetProperty(ref _sourceID);
			set => SetProperty(ref _sourceID, value);
		}

		[Ordinal(2)] 
		[RED("linkData")] 
		public SNetworkLinkData LinkData
		{
			get => GetProperty(ref _linkData);
			set => SetProperty(ref _linkData, value);
		}

		public RevealDeviceRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
