using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSyncNodeSignal : CVariable
	{
		private CUInt32 _nodeId;
		private CUInt16 _name;
		private CUInt16 _ordinal;
		private CUInt16 _numRuns;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CUInt32 NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (CUInt32) CR2WTypeManager.Create("Uint32", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CUInt16) CR2WTypeManager.Create("Uint16", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get
			{
				if (_ordinal == null)
				{
					_ordinal = (CUInt16) CR2WTypeManager.Create("Uint16", "ordinal", cr2w, this);
				}
				return _ordinal;
			}
			set
			{
				if (_ordinal == value)
				{
					return;
				}
				_ordinal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numRuns")] 
		public CUInt16 NumRuns
		{
			get
			{
				if (_numRuns == null)
				{
					_numRuns = (CUInt16) CR2WTypeManager.Create("Uint16", "numRuns", cr2w, this);
				}
				return _numRuns;
			}
			set
			{
				if (_numRuns == value)
				{
					return;
				}
				_numRuns = value;
				PropertySet(this);
			}
		}

		public scnSyncNodeSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
