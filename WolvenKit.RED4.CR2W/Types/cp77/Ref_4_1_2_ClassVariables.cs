using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_1_2_ClassVariables : IScriptable
	{
		private CInt32 _mul;
		private CInt32 _ti;
		private CInt32 _ple;
		private CInt32 _constVar;
		private CFloat _editVar;
		private CFloat _instEditVar;
		private CArray<CInt32> _inlinedVar;
		private CInt32 _repVar;
		private wCHandle<IScriptable> _weakVar;
		private CInt32 _persistentVar;

		[Ordinal(0)] 
		[RED("mul")] 
		public CInt32 Mul
		{
			get
			{
				if (_mul == null)
				{
					_mul = (CInt32) CR2WTypeManager.Create("Int32", "mul", cr2w, this);
				}
				return _mul;
			}
			set
			{
				if (_mul == value)
				{
					return;
				}
				_mul = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ti")] 
		public CInt32 Ti
		{
			get
			{
				if (_ti == null)
				{
					_ti = (CInt32) CR2WTypeManager.Create("Int32", "ti", cr2w, this);
				}
				return _ti;
			}
			set
			{
				if (_ti == value)
				{
					return;
				}
				_ti = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ple")] 
		public CInt32 Ple
		{
			get
			{
				if (_ple == null)
				{
					_ple = (CInt32) CR2WTypeManager.Create("Int32", "ple", cr2w, this);
				}
				return _ple;
			}
			set
			{
				if (_ple == value)
				{
					return;
				}
				_ple = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("constVar")] 
		public CInt32 ConstVar
		{
			get
			{
				if (_constVar == null)
				{
					_constVar = (CInt32) CR2WTypeManager.Create("Int32", "constVar", cr2w, this);
				}
				return _constVar;
			}
			set
			{
				if (_constVar == value)
				{
					return;
				}
				_constVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("editVar")] 
		public CFloat EditVar
		{
			get
			{
				if (_editVar == null)
				{
					_editVar = (CFloat) CR2WTypeManager.Create("Float", "editVar", cr2w, this);
				}
				return _editVar;
			}
			set
			{
				if (_editVar == value)
				{
					return;
				}
				_editVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instEditVar")] 
		public CFloat InstEditVar
		{
			get
			{
				if (_instEditVar == null)
				{
					_instEditVar = (CFloat) CR2WTypeManager.Create("Float", "instEditVar", cr2w, this);
				}
				return _instEditVar;
			}
			set
			{
				if (_instEditVar == value)
				{
					return;
				}
				_instEditVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("inlinedVar")] 
		public CArray<CInt32> InlinedVar
		{
			get
			{
				if (_inlinedVar == null)
				{
					_inlinedVar = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "inlinedVar", cr2w, this);
				}
				return _inlinedVar;
			}
			set
			{
				if (_inlinedVar == value)
				{
					return;
				}
				_inlinedVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("repVar")] 
		public CInt32 RepVar
		{
			get
			{
				if (_repVar == null)
				{
					_repVar = (CInt32) CR2WTypeManager.Create("Int32", "repVar", cr2w, this);
				}
				return _repVar;
			}
			set
			{
				if (_repVar == value)
				{
					return;
				}
				_repVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("weakVar")] 
		public wCHandle<IScriptable> WeakVar
		{
			get
			{
				if (_weakVar == null)
				{
					_weakVar = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "weakVar", cr2w, this);
				}
				return _weakVar;
			}
			set
			{
				if (_weakVar == value)
				{
					return;
				}
				_weakVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("persistentVar")] 
		public CInt32 PersistentVar
		{
			get
			{
				if (_persistentVar == null)
				{
					_persistentVar = (CInt32) CR2WTypeManager.Create("Int32", "persistentVar", cr2w, this);
				}
				return _persistentVar;
			}
			set
			{
				if (_persistentVar == value)
				{
					return;
				}
				_persistentVar = value;
				PropertySet(this);
			}
		}

		public Ref_4_1_2_ClassVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
