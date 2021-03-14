using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyCompletionEvent : redEvent
	{
		private CInt32 _streetCredAwarded;
		private CInt32 _moneyAwarded;

		[Ordinal(0)] 
		[RED("streetCredAwarded")] 
		public CInt32 StreetCredAwarded
		{
			get
			{
				if (_streetCredAwarded == null)
				{
					_streetCredAwarded = (CInt32) CR2WTypeManager.Create("Int32", "streetCredAwarded", cr2w, this);
				}
				return _streetCredAwarded;
			}
			set
			{
				if (_streetCredAwarded == value)
				{
					return;
				}
				_streetCredAwarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("moneyAwarded")] 
		public CInt32 MoneyAwarded
		{
			get
			{
				if (_moneyAwarded == null)
				{
					_moneyAwarded = (CInt32) CR2WTypeManager.Create("Int32", "moneyAwarded", cr2w, this);
				}
				return _moneyAwarded;
			}
			set
			{
				if (_moneyAwarded == value)
				{
					return;
				}
				_moneyAwarded = value;
				PropertySet(this);
			}
		}

		public BountyCompletionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
