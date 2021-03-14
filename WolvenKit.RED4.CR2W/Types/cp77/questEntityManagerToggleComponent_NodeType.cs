using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerToggleComponent_NodeType : questIEntityManager_NodeType
	{
		private CArray<questEntityManagerToggleComponent_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questEntityManagerToggleComponent_NodeTypeParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<questEntityManagerToggleComponent_NodeTypeParams>) CR2WTypeManager.Create("array:questEntityManagerToggleComponent_NodeTypeParams", "params", cr2w, this);
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

		public questEntityManagerToggleComponent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
