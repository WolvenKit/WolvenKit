using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionBoolData : SDeviceActionData
	{
		private TweakDBID _nameOnTrueRecord;
		private CString _nameOnTrue;
		private TweakDBID _nameOnFalseRecord;
		private CString _nameOnFalse;

		[Ordinal(10)] 
		[RED("nameOnTrueRecord")] 
		public TweakDBID NameOnTrueRecord
		{
			get => GetProperty(ref _nameOnTrueRecord);
			set => SetProperty(ref _nameOnTrueRecord, value);
		}

		[Ordinal(11)] 
		[RED("nameOnTrue")] 
		public CString NameOnTrue
		{
			get => GetProperty(ref _nameOnTrue);
			set => SetProperty(ref _nameOnTrue, value);
		}

		[Ordinal(12)] 
		[RED("nameOnFalseRecord")] 
		public TweakDBID NameOnFalseRecord
		{
			get => GetProperty(ref _nameOnFalseRecord);
			set => SetProperty(ref _nameOnFalseRecord, value);
		}

		[Ordinal(13)] 
		[RED("nameOnFalse")] 
		public CString NameOnFalse
		{
			get => GetProperty(ref _nameOnFalse);
			set => SetProperty(ref _nameOnFalse, value);
		}

		public SDeviceActionBoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
