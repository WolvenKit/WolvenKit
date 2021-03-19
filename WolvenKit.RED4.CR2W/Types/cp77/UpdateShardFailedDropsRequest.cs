using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateShardFailedDropsRequest : gameScriptableSystemRequest
	{
		private CBool _resetCounter;
		private CFloat _newFailedAttempts;

		[Ordinal(0)] 
		[RED("resetCounter")] 
		public CBool ResetCounter
		{
			get => GetProperty(ref _resetCounter);
			set => SetProperty(ref _resetCounter, value);
		}

		[Ordinal(1)] 
		[RED("newFailedAttempts")] 
		public CFloat NewFailedAttempts
		{
			get => GetProperty(ref _newFailedAttempts);
			set => SetProperty(ref _newFailedAttempts, value);
		}

		public UpdateShardFailedDropsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
