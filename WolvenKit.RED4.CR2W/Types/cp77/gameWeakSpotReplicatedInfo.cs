using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakSpotReplicatedInfo : CVariable
	{
		private CUInt64 _weakSpotRecordID;
		private CFloat _wsHealthValue;
		private wCHandle<gamePuppet> _lastDamageInstigator;

		[Ordinal(0)] 
		[RED("weakSpotRecordID")] 
		public CUInt64 WeakSpotRecordID
		{
			get
			{
				if (_weakSpotRecordID == null)
				{
					_weakSpotRecordID = (CUInt64) CR2WTypeManager.Create("Uint64", "weakSpotRecordID", cr2w, this);
				}
				return _weakSpotRecordID;
			}
			set
			{
				if (_weakSpotRecordID == value)
				{
					return;
				}
				_weakSpotRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wsHealthValue")] 
		public CFloat WsHealthValue
		{
			get
			{
				if (_wsHealthValue == null)
				{
					_wsHealthValue = (CFloat) CR2WTypeManager.Create("Float", "wsHealthValue", cr2w, this);
				}
				return _wsHealthValue;
			}
			set
			{
				if (_wsHealthValue == value)
				{
					return;
				}
				_wsHealthValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("LastDamageInstigator")] 
		public wCHandle<gamePuppet> LastDamageInstigator
		{
			get
			{
				if (_lastDamageInstigator == null)
				{
					_lastDamageInstigator = (wCHandle<gamePuppet>) CR2WTypeManager.Create("whandle:gamePuppet", "LastDamageInstigator", cr2w, this);
				}
				return _lastDamageInstigator;
			}
			set
			{
				if (_lastDamageInstigator == value)
				{
					return;
				}
				_lastDamageInstigator = value;
				PropertySet(this);
			}
		}

		public gameWeakSpotReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
