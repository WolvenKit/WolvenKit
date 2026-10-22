using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_1_2_ClassVariables : IScriptable
	{
		[Ordinal(0)] 
		[RED("mul")] 
		public CInt32 Mul
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("ti")] 
		public CInt32 Ti
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ple")] 
		public CInt32 Ple
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("constVar")] 
		public CInt32 ConstVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("editVar")] 
		public CFloat EditVar
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("instEditVar")] 
		public CFloat InstEditVar
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("inlinedVar")] 
		public CArray<CInt32> InlinedVar
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(7)] 
		[RED("repVar")] 
		public CInt32 RepVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("weakVar")] 
		public CWeakHandle<IScriptable> WeakVar
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(9)] 
		[RED("persistentVar")] 
		public CInt32 PersistentVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_4_1_2_ClassVariables()
		{
			InlinedVar = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
