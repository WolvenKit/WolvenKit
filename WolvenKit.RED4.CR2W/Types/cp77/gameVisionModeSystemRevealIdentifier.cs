using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeSystemRevealIdentifier : CVariable
	{
		private entEntityID _sourceEntityId;
		private CName _reason;

		[Ordinal(0)] 
		[RED("sourceEntityId")] 
		public entEntityID SourceEntityId
		{
			get => GetProperty(ref _sourceEntityId);
			set => SetProperty(ref _sourceEntityId, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		public gameVisionModeSystemRevealIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
