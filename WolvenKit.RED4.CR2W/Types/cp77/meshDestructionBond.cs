using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshDestructionBond : CVariable
	{
		private CUInt16 _bondIndex;
		private CUInt8 _bondHealth;

		[Ordinal(0)] 
		[RED("bondIndex")] 
		public CUInt16 BondIndex
		{
			get
			{
				if (_bondIndex == null)
				{
					_bondIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "bondIndex", cr2w, this);
				}
				return _bondIndex;
			}
			set
			{
				if (_bondIndex == value)
				{
					return;
				}
				_bondIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bondHealth")] 
		public CUInt8 BondHealth
		{
			get
			{
				if (_bondHealth == null)
				{
					_bondHealth = (CUInt8) CR2WTypeManager.Create("Uint8", "bondHealth", cr2w, this);
				}
				return _bondHealth;
			}
			set
			{
				if (_bondHealth == value)
				{
					return;
				}
				_bondHealth = value;
				PropertySet(this);
			}
		}

		public meshDestructionBond(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
