using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Bounty : CVariable
	{
		private CArray<TweakDBID> _transgressions;
		private TweakDBID _bountySetter;
		private CInt32 _moneyAmount;
		private CInt32 _streetCredAmount;
		private CBool _awarded;
		private CInt32 _wantedStars;

		[Ordinal(0)] 
		[RED("transgressions")] 
		public CArray<TweakDBID> Transgressions
		{
			get
			{
				if (_transgressions == null)
				{
					_transgressions = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "transgressions", cr2w, this);
				}
				return _transgressions;
			}
			set
			{
				if (_transgressions == value)
				{
					return;
				}
				_transgressions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bountySetter")] 
		public TweakDBID BountySetter
		{
			get
			{
				if (_bountySetter == null)
				{
					_bountySetter = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bountySetter", cr2w, this);
				}
				return _bountySetter;
			}
			set
			{
				if (_bountySetter == value)
				{
					return;
				}
				_bountySetter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("moneyAmount")] 
		public CInt32 MoneyAmount
		{
			get
			{
				if (_moneyAmount == null)
				{
					_moneyAmount = (CInt32) CR2WTypeManager.Create("Int32", "moneyAmount", cr2w, this);
				}
				return _moneyAmount;
			}
			set
			{
				if (_moneyAmount == value)
				{
					return;
				}
				_moneyAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("streetCredAmount")] 
		public CInt32 StreetCredAmount
		{
			get
			{
				if (_streetCredAmount == null)
				{
					_streetCredAmount = (CInt32) CR2WTypeManager.Create("Int32", "streetCredAmount", cr2w, this);
				}
				return _streetCredAmount;
			}
			set
			{
				if (_streetCredAmount == value)
				{
					return;
				}
				_streetCredAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get
			{
				if (_awarded == null)
				{
					_awarded = (CBool) CR2WTypeManager.Create("Bool", "awarded", cr2w, this);
				}
				return _awarded;
			}
			set
			{
				if (_awarded == value)
				{
					return;
				}
				_awarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("wantedStars")] 
		public CInt32 WantedStars
		{
			get
			{
				if (_wantedStars == null)
				{
					_wantedStars = (CInt32) CR2WTypeManager.Create("Int32", "wantedStars", cr2w, this);
				}
				return _wantedStars;
			}
			set
			{
				if (_wantedStars == value)
				{
					return;
				}
				_wantedStars = value;
				PropertySet(this);
			}
		}

		public Bounty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
