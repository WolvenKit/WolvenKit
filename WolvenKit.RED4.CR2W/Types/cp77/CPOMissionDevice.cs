using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDevice : gameObject
	{
		private CName _compatibleDeviceName;
		private CBool _blockAfterOperation;
		private CName _factToUnblock;
		private CBool _isBlocked;
		private CUInt32 _factUnblockCallbackID;

		[Ordinal(40)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get
			{
				if (_compatibleDeviceName == null)
				{
					_compatibleDeviceName = (CName) CR2WTypeManager.Create("CName", "compatibleDeviceName", cr2w, this);
				}
				return _compatibleDeviceName;
			}
			set
			{
				if (_compatibleDeviceName == value)
				{
					return;
				}
				_compatibleDeviceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("blockAfterOperation")] 
		public CBool BlockAfterOperation
		{
			get
			{
				if (_blockAfterOperation == null)
				{
					_blockAfterOperation = (CBool) CR2WTypeManager.Create("Bool", "blockAfterOperation", cr2w, this);
				}
				return _blockAfterOperation;
			}
			set
			{
				if (_blockAfterOperation == value)
				{
					return;
				}
				_blockAfterOperation = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("factToUnblock")] 
		public CName FactToUnblock
		{
			get
			{
				if (_factToUnblock == null)
				{
					_factToUnblock = (CName) CR2WTypeManager.Create("CName", "factToUnblock", cr2w, this);
				}
				return _factToUnblock;
			}
			set
			{
				if (_factToUnblock == value)
				{
					return;
				}
				_factToUnblock = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("factUnblockCallbackID")] 
		public CUInt32 FactUnblockCallbackID
		{
			get
			{
				if (_factUnblockCallbackID == null)
				{
					_factUnblockCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "factUnblockCallbackID", cr2w, this);
				}
				return _factUnblockCallbackID;
			}
			set
			{
				if (_factUnblockCallbackID == value)
				{
					return;
				}
				_factUnblockCallbackID = value;
				PropertySet(this);
			}
		}

		public CPOMissionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
