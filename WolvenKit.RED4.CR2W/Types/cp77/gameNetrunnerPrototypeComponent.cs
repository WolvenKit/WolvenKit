using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeComponent : entIComponent
	{
		private CArray<gameNetrunnerPrototypeStruct> _structs;

		[Ordinal(3)] 
		[RED("structs")] 
		public CArray<gameNetrunnerPrototypeStruct> Structs
		{
			get
			{
				if (_structs == null)
				{
					_structs = (CArray<gameNetrunnerPrototypeStruct>) CR2WTypeManager.Create("array:gameNetrunnerPrototypeStruct", "structs", cr2w, this);
				}
				return _structs;
			}
			set
			{
				if (_structs == value)
				{
					return;
				}
				_structs = value;
				PropertySet(this);
			}
		}

		public gameNetrunnerPrototypeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
