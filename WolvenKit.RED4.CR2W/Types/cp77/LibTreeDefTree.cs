using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTree : CVariable
	{
		private CUInt16 _variableId;
		private CName _treeVariable;
		private CHandle<LibTreeCTreeReference> _v;

		[Ordinal(0)] 
		[RED("variableId")] 
		public CUInt16 VariableId
		{
			get
			{
				if (_variableId == null)
				{
					_variableId = (CUInt16) CR2WTypeManager.Create("Uint16", "variableId", cr2w, this);
				}
				return _variableId;
			}
			set
			{
				if (_variableId == value)
				{
					return;
				}
				_variableId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("treeVariable")] 
		public CName TreeVariable
		{
			get
			{
				if (_treeVariable == null)
				{
					_treeVariable = (CName) CR2WTypeManager.Create("CName", "treeVariable", cr2w, this);
				}
				return _treeVariable;
			}
			set
			{
				if (_treeVariable == value)
				{
					return;
				}
				_treeVariable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("v")] 
		public CHandle<LibTreeCTreeReference> V
		{
			get
			{
				if (_v == null)
				{
					_v = (CHandle<LibTreeCTreeReference>) CR2WTypeManager.Create("handle:LibTreeCTreeReference", "v", cr2w, this);
				}
				return _v;
			}
			set
			{
				if (_v == value)
				{
					return;
				}
				_v = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
