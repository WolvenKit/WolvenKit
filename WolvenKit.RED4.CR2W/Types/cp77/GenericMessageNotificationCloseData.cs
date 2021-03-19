using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		private CInt32 _identifier;
		private CEnum<GenericMessageNotificationResult> _result;

		[Ordinal(6)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(7)] 
		[RED("result")] 
		public CEnum<GenericMessageNotificationResult> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		public GenericMessageNotificationCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
