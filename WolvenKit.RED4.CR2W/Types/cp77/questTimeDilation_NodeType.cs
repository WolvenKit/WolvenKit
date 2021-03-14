using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CArray<CHandle<questTimeDilation_NodeTypeParam>> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questTimeDilation_NodeTypeParam>> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<CHandle<questTimeDilation_NodeTypeParam>>) CR2WTypeManager.Create("array:handle:questTimeDilation_NodeTypeParam", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questTimeDilation_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
