using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_1_2_StructureVariables : CVariable
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
			get => GetProperty(ref _mul);
			set => SetProperty(ref _mul, value);
		}

		[Ordinal(1)] 
		[RED("ti")] 
		public CInt32 Ti
		{
			get => GetProperty(ref _ti);
			set => SetProperty(ref _ti, value);
		}

		[Ordinal(2)] 
		[RED("ple")] 
		public CInt32 Ple
		{
			get => GetProperty(ref _ple);
			set => SetProperty(ref _ple, value);
		}

		[Ordinal(3)] 
		[RED("constVar")] 
		public CInt32 ConstVar
		{
			get => GetProperty(ref _constVar);
			set => SetProperty(ref _constVar, value);
		}

		[Ordinal(4)] 
		[RED("editVar")] 
		public CFloat EditVar
		{
			get => GetProperty(ref _editVar);
			set => SetProperty(ref _editVar, value);
		}

		[Ordinal(5)] 
		[RED("instEditVar")] 
		public CFloat InstEditVar
		{
			get => GetProperty(ref _instEditVar);
			set => SetProperty(ref _instEditVar, value);
		}

		[Ordinal(6)] 
		[RED("inlinedVar")] 
		public CArray<CInt32> InlinedVar
		{
			get => GetProperty(ref _inlinedVar);
			set => SetProperty(ref _inlinedVar, value);
		}

		[Ordinal(7)] 
		[RED("repVar")] 
		public CInt32 RepVar
		{
			get => GetProperty(ref _repVar);
			set => SetProperty(ref _repVar, value);
		}

		[Ordinal(8)] 
		[RED("weakVar")] 
		public wCHandle<IScriptable> WeakVar
		{
			get => GetProperty(ref _weakVar);
			set => SetProperty(ref _weakVar, value);
		}

		[Ordinal(9)] 
		[RED("persistentVar")] 
		public CInt32 PersistentVar
		{
			get => GetProperty(ref _persistentVar);
			set => SetProperty(ref _persistentVar, value);
		}

		public Ref_4_1_2_StructureVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
