using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneRestriction_NodeType : questIPhoneManagerNodeType
	{
		private CBool _applyPhoneRestriction;
		private CBool _forcedApply;
		private CName _forcedApplySource;

		[Ordinal(0)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetProperty(ref _applyPhoneRestriction);
			set => SetProperty(ref _applyPhoneRestriction, value);
		}

		[Ordinal(1)] 
		[RED("forcedApply")] 
		public CBool ForcedApply
		{
			get => GetProperty(ref _forcedApply);
			set => SetProperty(ref _forcedApply, value);
		}

		[Ordinal(2)] 
		[RED("forcedApplySource")] 
		public CName ForcedApplySource
		{
			get => GetProperty(ref _forcedApplySource);
			set => SetProperty(ref _forcedApplySource, value);
		}

		public questSetPhoneRestriction_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
