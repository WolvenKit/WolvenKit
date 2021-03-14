using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackData : CVariable
	{
		private CUInt64 _resourceHash;
		private CArray<questdbgCallstackPhase> _phases;
		private CArray<questdbgCallstackBlock> _blocks;
		private CArray<CUInt64> _executed;
		private CArray<CUInt64> _failed;
		private CUInt32 _callstackRevision;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get
			{
				if (_resourceHash == null)
				{
					_resourceHash = (CUInt64) CR2WTypeManager.Create("Uint64", "resourceHash", cr2w, this);
				}
				return _resourceHash;
			}
			set
			{
				if (_resourceHash == value)
				{
					return;
				}
				_resourceHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("phases")] 
		public CArray<questdbgCallstackPhase> Phases
		{
			get
			{
				if (_phases == null)
				{
					_phases = (CArray<questdbgCallstackPhase>) CR2WTypeManager.Create("array:questdbgCallstackPhase", "phases", cr2w, this);
				}
				return _phases;
			}
			set
			{
				if (_phases == value)
				{
					return;
				}
				_phases = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blocks")] 
		public CArray<questdbgCallstackBlock> Blocks
		{
			get
			{
				if (_blocks == null)
				{
					_blocks = (CArray<questdbgCallstackBlock>) CR2WTypeManager.Create("array:questdbgCallstackBlock", "blocks", cr2w, this);
				}
				return _blocks;
			}
			set
			{
				if (_blocks == value)
				{
					return;
				}
				_blocks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("executed")] 
		public CArray<CUInt64> Executed
		{
			get
			{
				if (_executed == null)
				{
					_executed = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "executed", cr2w, this);
				}
				return _executed;
			}
			set
			{
				if (_executed == value)
				{
					return;
				}
				_executed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("failed")] 
		public CArray<CUInt64> Failed
		{
			get
			{
				if (_failed == null)
				{
					_failed = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "failed", cr2w, this);
				}
				return _failed;
			}
			set
			{
				if (_failed == value)
				{
					return;
				}
				_failed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("callstackRevision")] 
		public CUInt32 CallstackRevision
		{
			get
			{
				if (_callstackRevision == null)
				{
					_callstackRevision = (CUInt32) CR2WTypeManager.Create("Uint32", "callstackRevision", cr2w, this);
				}
				return _callstackRevision;
			}
			set
			{
				if (_callstackRevision == value)
				{
					return;
				}
				_callstackRevision = value;
				PropertySet(this);
			}
		}

		public questdbgCallstackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
