using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionBonds : meshMeshParameter
	{
		private CArray<meshDestructionBond> _bonds;

		[Ordinal(0)] 
		[RED("bonds")] 
		public CArray<meshDestructionBond> Bonds
		{
			get
			{
				if (_bonds == null)
				{
					_bonds = (CArray<meshDestructionBond>) CR2WTypeManager.Create("array:meshDestructionBond", "bonds", cr2w, this);
				}
				return _bonds;
			}
			set
			{
				if (_bonds == value)
				{
					return;
				}
				_bonds = value;
				PropertySet(this);
			}
		}

		public meshMeshParamDestructionBonds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
