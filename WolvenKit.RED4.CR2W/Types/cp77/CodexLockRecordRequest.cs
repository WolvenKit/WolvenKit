using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexLockRecordRequest : gameScriptableSystemRequest
	{
		private TweakDBID _codexRecordID;

		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get => GetProperty(ref _codexRecordID);
			set => SetProperty(ref _codexRecordID, value);
		}

		public CodexLockRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
