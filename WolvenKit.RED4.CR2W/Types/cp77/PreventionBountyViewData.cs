using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionBountyViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;
		private CString _bountyTitle;
		private CInt32 _bountyPrice;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get
			{
				if (_canBeMerged == null)
				{
					_canBeMerged = (CBool) CR2WTypeManager.Create("Bool", "canBeMerged", cr2w, this);
				}
				return _canBeMerged;
			}
			set
			{
				if (_canBeMerged == value)
				{
					return;
				}
				_canBeMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bountyTitle")] 
		public CString BountyTitle
		{
			get
			{
				if (_bountyTitle == null)
				{
					_bountyTitle = (CString) CR2WTypeManager.Create("String", "bountyTitle", cr2w, this);
				}
				return _bountyTitle;
			}
			set
			{
				if (_bountyTitle == value)
				{
					return;
				}
				_bountyTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bountyPrice")] 
		public CInt32 BountyPrice
		{
			get
			{
				if (_bountyPrice == null)
				{
					_bountyPrice = (CInt32) CR2WTypeManager.Create("Int32", "bountyPrice", cr2w, this);
				}
				return _bountyPrice;
			}
			set
			{
				if (_bountyPrice == value)
				{
					return;
				}
				_bountyPrice = value;
				PropertySet(this);
			}
		}

		public PreventionBountyViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
