using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		private entEntityID _firstID;
		private entEntityID _secondID;
		private CBool _onlyRemoveWeakLink;

		[Ordinal(0)] 
		[RED("firstID")] 
		public entEntityID FirstID
		{
			get => GetProperty(ref _firstID);
			set => SetProperty(ref _firstID, value);
		}

		[Ordinal(1)] 
		[RED("secondID")] 
		public entEntityID SecondID
		{
			get => GetProperty(ref _secondID);
			set => SetProperty(ref _secondID, value);
		}

		[Ordinal(2)] 
		[RED("onlyRemoveWeakLink")] 
		public CBool OnlyRemoveWeakLink
		{
			get => GetProperty(ref _onlyRemoveWeakLink);
			set => SetProperty(ref _onlyRemoveWeakLink, value);
		}

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
