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
			get
			{
				if (_diff == null)
				{
					_diff = (CInt32) CR2WTypeManager.Create("Int32", "diff", cr2w, this);
				}
				return _diff;
			}
			set
			{
				if (_diff == value)
				{
					return;
				}
				_diff = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get
			{
				if (_total == null)
				{
					_total = (CUInt32) CR2WTypeManager.Create("Uint32", "total", cr2w, this);
				}
				return _total;
			}
			set
			{
				if (_total == value)
				{
					return;
				}
				_total = value;
				PropertySet(this);
			}
		}

		public CurrencyUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
