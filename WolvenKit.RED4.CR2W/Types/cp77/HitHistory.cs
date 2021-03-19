using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitHistory : IScriptable
	{
		private CArray<HitHistoryItem> _hitHistory;
		private CInt32 _maxEntries;

		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<HitHistoryItem> HitHistory_
		{
			get => GetProperty(ref _hitHistory);
			set => SetProperty(ref _hitHistory, value);
		}

		[Ordinal(1)] 
		[RED("maxEntries")] 
		public CInt32 MaxEntries
		{
			get => GetProperty(ref _maxEntries);
			set => SetProperty(ref _maxEntries, value);
		}

		public HitHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
