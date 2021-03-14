using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopSelectByDefinitionOptions : CVariable
	{
		private CBool _searchInSelection;
		private CFloat _minBBoxDiagonalLength;
		private CFloat _maxBBoxDiagonalLength;
		private CFloat _maxBBoxParentPercantageDiagonalLength;
		private CBool _includePrefabNodes;
		private CBool _includeDecalNodes;
		private CBool _includeMeshNodes;

		[Ordinal(0)] 
		[RED("searchInSelection")] 
		public CBool SearchInSelection
		{
			get
			{
				if (_searchInSelection == null)
				{
					_searchInSelection = (CBool) CR2WTypeManager.Create("Bool", "searchInSelection", cr2w, this);
				}
				return _searchInSelection;
			}
			set
			{
				if (_searchInSelection == value)
				{
					return;
				}
				_searchInSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minBBoxDiagonalLength")] 
		public CFloat MinBBoxDiagonalLength
		{
			get
			{
				if (_minBBoxDiagonalLength == null)
				{
					_minBBoxDiagonalLength = (CFloat) CR2WTypeManager.Create("Float", "minBBoxDiagonalLength", cr2w, this);
				}
				return _minBBoxDiagonalLength;
			}
			set
			{
				if (_minBBoxDiagonalLength == value)
				{
					return;
				}
				_minBBoxDiagonalLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxBBoxDiagonalLength")] 
		public CFloat MaxBBoxDiagonalLength
		{
			get
			{
				if (_maxBBoxDiagonalLength == null)
				{
					_maxBBoxDiagonalLength = (CFloat) CR2WTypeManager.Create("Float", "maxBBoxDiagonalLength", cr2w, this);
				}
				return _maxBBoxDiagonalLength;
			}
			set
			{
				if (_maxBBoxDiagonalLength == value)
				{
					return;
				}
				_maxBBoxDiagonalLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxBBoxParentPercantageDiagonalLength")] 
		public CFloat MaxBBoxParentPercantageDiagonalLength
		{
			get
			{
				if (_maxBBoxParentPercantageDiagonalLength == null)
				{
					_maxBBoxParentPercantageDiagonalLength = (CFloat) CR2WTypeManager.Create("Float", "maxBBoxParentPercantageDiagonalLength", cr2w, this);
				}
				return _maxBBoxParentPercantageDiagonalLength;
			}
			set
			{
				if (_maxBBoxParentPercantageDiagonalLength == value)
				{
					return;
				}
				_maxBBoxParentPercantageDiagonalLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("includePrefabNodes")] 
		public CBool IncludePrefabNodes
		{
			get
			{
				if (_includePrefabNodes == null)
				{
					_includePrefabNodes = (CBool) CR2WTypeManager.Create("Bool", "includePrefabNodes", cr2w, this);
				}
				return _includePrefabNodes;
			}
			set
			{
				if (_includePrefabNodes == value)
				{
					return;
				}
				_includePrefabNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("includeDecalNodes")] 
		public CBool IncludeDecalNodes
		{
			get
			{
				if (_includeDecalNodes == null)
				{
					_includeDecalNodes = (CBool) CR2WTypeManager.Create("Bool", "includeDecalNodes", cr2w, this);
				}
				return _includeDecalNodes;
			}
			set
			{
				if (_includeDecalNodes == value)
				{
					return;
				}
				_includeDecalNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("includeMeshNodes")] 
		public CBool IncludeMeshNodes
		{
			get
			{
				if (_includeMeshNodes == null)
				{
					_includeMeshNodes = (CBool) CR2WTypeManager.Create("Bool", "includeMeshNodes", cr2w, this);
				}
				return _includeMeshNodes;
			}
			set
			{
				if (_includeMeshNodes == value)
				{
					return;
				}
				_includeMeshNodes = value;
				PropertySet(this);
			}
		}

		public interopSelectByDefinitionOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
