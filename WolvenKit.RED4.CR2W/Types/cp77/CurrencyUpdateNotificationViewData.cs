using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		private CInt32 _diff;
		private CUInt32 _total;

		[Ordinal(5)] 
		[RED("diff")] 
		public CInt32 Diff
		{
			get => GetProperty(ref _diff);
			set => SetProperty(ref _diff, value);
		}

		[Ordinal(6)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get => GetProperty(ref _total);
			set => SetProperty(ref _total, value);
		}

		public CurrencyUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
