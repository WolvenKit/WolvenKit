using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackPhase : questdbgCallstackBlock
	{
		private CArray<CUInt64> _phases;
		private CArray<CUInt64> _blocks;

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CUInt64> Phases
		{
			get
			{
				if (_phases == null)
				{
					_phases = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "phases", cr2w, this);
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

		[Ordinal(3)] 
		[RED("blocks")] 
		public CArray<CUInt64> Blocks
		{
			get
			{
				if (_blocks == null)
				{
					_blocks = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "blocks", cr2w, this);
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

		public questdbgCallstackPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
