using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealRequestsStorage : IScriptable
	{
		private CInt32 _currentRequestersAmount;
		private CArray<entEntityID> _requestersList;

		[Ordinal(0)] 
		[RED("currentRequestersAmount")] 
		public CInt32 CurrentRequestersAmount
		{
			get
			{
				if (_currentRequestersAmount == null)
				{
					_currentRequestersAmount = (CInt32) CR2WTypeManager.Create("Int32", "currentRequestersAmount", cr2w, this);
				}
				return _currentRequestersAmount;
			}
			set
			{
				if (_currentRequestersAmount == value)
				{
					return;
				}
				_currentRequestersAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requestersList")] 
		public CArray<entEntityID> RequestersList
		{
			get
			{
				if (_requestersList == null)
				{
					_requestersList = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "requestersList", cr2w, this);
				}
				return _requestersList;
			}
			set
			{
				if (_requestersList == value)
				{
					return;
				}
				_requestersList = value;
				PropertySet(this);
			}
		}

		public RevealRequestsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
