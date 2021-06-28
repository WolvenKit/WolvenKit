using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtBasicEventData : CVariable
	{
		private scnAnimTargetBasicData _basic;
		private CBool _removePreviousAdvancedLookAts;
		private CArray<animLookAtRequestForPart> _requests;

		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetProperty(ref _basic);
			set => SetProperty(ref _basic, value);
		}

		[Ordinal(1)] 
		[RED("removePreviousAdvancedLookAts")] 
		public CBool RemovePreviousAdvancedLookAts
		{
			get => GetProperty(ref _removePreviousAdvancedLookAts);
			set => SetProperty(ref _removePreviousAdvancedLookAts, value);
		}

		[Ordinal(2)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetProperty(ref _requests);
			set => SetProperty(ref _requests, value);
		}

		public scnLookAtBasicEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
