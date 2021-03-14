using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_SubStructure : CVariable
	{
		private CBool _exampleSubStructureVar;

		[Ordinal(0)] 
		[RED("exampleSubStructureVar")] 
		public CBool ExampleSubStructureVar
		{
			get
			{
				if (_exampleSubStructureVar == null)
				{
					_exampleSubStructureVar = (CBool) CR2WTypeManager.Create("Bool", "exampleSubStructureVar", cr2w, this);
				}
				return _exampleSubStructureVar;
			}
			set
			{
				if (_exampleSubStructureVar == value)
				{
					return;
				}
				_exampleSubStructureVar = value;
				PropertySet(this);
			}
		}

		public Ref_6_ReplicatedVariables_SubStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
