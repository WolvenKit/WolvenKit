using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<TrespasserEntry> _tresspasserList;
		private entEntityID _entranceToken;
		private CBool _isLeaving;
		private CBool _isLocked;

		[Ordinal(103)] 
		[RED("tresspasserList")] 
		public CArray<TrespasserEntry> TresspasserList
		{
			get
			{
				if (_tresspasserList == null)
				{
					_tresspasserList = (CArray<TrespasserEntry>) CR2WTypeManager.Create("array:TrespasserEntry", "tresspasserList", cr2w, this);
				}
				return _tresspasserList;
			}
			set
			{
				if (_tresspasserList == value)
				{
					return;
				}
				_tresspasserList = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("entranceToken")] 
		public entEntityID EntranceToken
		{
			get
			{
				if (_entranceToken == null)
				{
					_entranceToken = (entEntityID) CR2WTypeManager.Create("entEntityID", "entranceToken", cr2w, this);
				}
				return _entranceToken;
			}
			set
			{
				if (_entranceToken == value)
				{
					return;
				}
				_entranceToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("isLeaving")] 
		public CBool IsLeaving
		{
			get
			{
				if (_isLeaving == null)
				{
					_isLeaving = (CBool) CR2WTypeManager.Create("Bool", "isLeaving", cr2w, this);
				}
				return _isLeaving;
			}
			set
			{
				if (_isLeaving == value)
				{
					return;
				}
				_isLeaving = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		public SecurityGateLockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
