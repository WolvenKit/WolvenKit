using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNodeType : CVariable
	{
		private CName _typeName;

		[Ordinal(0)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get
			{
				if (_typeName == null)
				{
					_typeName = (CName) CR2WTypeManager.Create("CName", "typeName", cr2w, this);
				}
				return _typeName;
			}
			set
			{
				if (_typeName == value)
				{
					return;
				}
				_typeName = value;
				PropertySet(this);
			}
		}

		public worldWaterPatchNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
