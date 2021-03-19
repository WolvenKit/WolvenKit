using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayDialogLine : CVariable
	{
		private scnscreenplayItemId _itemId;
		private scnActorId _speaker;
		private scnActorId _addressee;
		private scnscreenplayLineUsage _usage;
		private scnlocLocstringId _locstringId;
		private CName _maleLipsyncAnimationName;
		private CName _femaleLipsyncAnimationName;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("speaker")] 
		public scnActorId Speaker
		{
			get => GetProperty(ref _speaker);
			set => SetProperty(ref _speaker, value);
		}

		[Ordinal(2)] 
		[RED("addressee")] 
		public scnActorId Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(3)] 
		[RED("usage")] 
		public scnscreenplayLineUsage Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(4)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetProperty(ref _locstringId);
			set => SetProperty(ref _locstringId, value);
		}

		[Ordinal(5)] 
		[RED("maleLipsyncAnimationName")] 
		public CName MaleLipsyncAnimationName
		{
			get => GetProperty(ref _maleLipsyncAnimationName);
			set => SetProperty(ref _maleLipsyncAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("femaleLipsyncAnimationName")] 
		public CName FemaleLipsyncAnimationName
		{
			get => GetProperty(ref _femaleLipsyncAnimationName);
			set => SetProperty(ref _femaleLipsyncAnimationName, value);
		}

		public scnscreenplayDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
