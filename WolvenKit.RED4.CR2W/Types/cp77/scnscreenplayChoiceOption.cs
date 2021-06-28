using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayChoiceOption : CVariable
	{
		private scnscreenplayItemId _itemId;
		private scnscreenplayOptionUsage _usage;
		private scnlocLocstringId _locstringId;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public scnscreenplayOptionUsage Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(2)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetProperty(ref _locstringId);
			set => SetProperty(ref _locstringId, value);
		}

		public scnscreenplayChoiceOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
