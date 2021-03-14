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
			get
			{
				if (_hitHistory == null)
				{
					_hitHistory = (CArray<HitHistoryItem>) CR2WTypeManager.Create("array:HitHistoryItem", "hitHistory", cr2w, this);
				}
				return _hitHistory;
			}
			set
			{
				if (_hitHistory == value)
				{
					return;
				}
				_hitHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxEntries")] 
		public CInt32 MaxEntries
		{
			get
			{
				if (_maxEntries == null)
				{
					_maxEntries = (CInt32) CR2WTypeManager.Create("Int32", "maxEntries", cr2w, this);
				}
				return _maxEntries;
			}
			set
			{
				if (_maxEntries == value)
				{
					return;
				}
				_maxEntries = value;
				PropertySet(this);
			}
		}

		public HitHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
