using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IMaterialDefinition : IMaterial
	{
		private CArrayFixedSize<CUInt32> _paramBlockSize;
		private CBool _compileAllTechniques;
		private CBool _canHaveTangentUpdate;
		private CBool _canHaveDismemberment;
		private CBool _hasDPL;
		private CUInt8 _materialVersion;
		private CArray<CEnum<EMaterialVertexFactory>> _vertexFactories;

		[Ordinal(1)] 
		[RED("paramBlockSize", 3)] 
		public CArrayFixedSize<CUInt32> ParamBlockSize
		{
			get
			{
				if (_paramBlockSize == null)
				{
					_paramBlockSize = (CArrayFixedSize<CUInt32>) CR2WTypeManager.Create("[3]Uint32", "paramBlockSize", cr2w, this);
				}
				return _paramBlockSize;
			}
			set
			{
				if (_paramBlockSize == value)
				{
					return;
				}
				_paramBlockSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compileAllTechniques")] 
		public CBool CompileAllTechniques
		{
			get
			{
				if (_compileAllTechniques == null)
				{
					_compileAllTechniques = (CBool) CR2WTypeManager.Create("Bool", "compileAllTechniques", cr2w, this);
				}
				return _compileAllTechniques;
			}
			set
			{
				if (_compileAllTechniques == value)
				{
					return;
				}
				_compileAllTechniques = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("canHaveTangentUpdate")] 
		public CBool CanHaveTangentUpdate
		{
			get
			{
				if (_canHaveTangentUpdate == null)
				{
					_canHaveTangentUpdate = (CBool) CR2WTypeManager.Create("Bool", "canHaveTangentUpdate", cr2w, this);
				}
				return _canHaveTangentUpdate;
			}
			set
			{
				if (_canHaveTangentUpdate == value)
				{
					return;
				}
				_canHaveTangentUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("canHaveDismemberment")] 
		public CBool CanHaveDismemberment
		{
			get
			{
				if (_canHaveDismemberment == null)
				{
					_canHaveDismemberment = (CBool) CR2WTypeManager.Create("Bool", "canHaveDismemberment", cr2w, this);
				}
				return _canHaveDismemberment;
			}
			set
			{
				if (_canHaveDismemberment == value)
				{
					return;
				}
				_canHaveDismemberment = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hasDPL")] 
		public CBool HasDPL
		{
			get
			{
				if (_hasDPL == null)
				{
					_hasDPL = (CBool) CR2WTypeManager.Create("Bool", "hasDPL", cr2w, this);
				}
				return _hasDPL;
			}
			set
			{
				if (_hasDPL == value)
				{
					return;
				}
				_hasDPL = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("materialVersion")] 
		public CUInt8 MaterialVersion
		{
			get
			{
				if (_materialVersion == null)
				{
					_materialVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "materialVersion", cr2w, this);
				}
				return _materialVersion;
			}
			set
			{
				if (_materialVersion == value)
				{
					return;
				}
				_materialVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vertexFactories")] 
		public CArray<CEnum<EMaterialVertexFactory>> VertexFactories
		{
			get
			{
				if (_vertexFactories == null)
				{
					_vertexFactories = (CArray<CEnum<EMaterialVertexFactory>>) CR2WTypeManager.Create("array:EMaterialVertexFactory", "vertexFactories", cr2w, this);
				}
				return _vertexFactories;
			}
			set
			{
				if (_vertexFactories == value)
				{
					return;
				}
				_vertexFactories = value;
				PropertySet(this);
			}
		}

		public IMaterialDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
