using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_Container_2 : CVariable
	{
		private CFloat _floatBox;
		private CInt32 _intBox;
		private CBool _boolBox;
		private CName _nameBox;
		private CString _stringBox;
		private CName _cNameBox;
		private TweakDBID _tweakBox;

		[Ordinal(0)] 
		[RED("FloatBox")] 
		public CFloat FloatBox
		{
			get => GetProperty(ref _floatBox);
			set => SetProperty(ref _floatBox, value);
		}

		[Ordinal(1)] 
		[RED("IntBox")] 
		public CInt32 IntBox
		{
			get => GetProperty(ref _intBox);
			set => SetProperty(ref _intBox, value);
		}

		[Ordinal(2)] 
		[RED("BoolBox")] 
		public CBool BoolBox
		{
			get => GetProperty(ref _boolBox);
			set => SetProperty(ref _boolBox, value);
		}

		[Ordinal(3)] 
		[RED("NameBox")] 
		public CName NameBox
		{
			get => GetProperty(ref _nameBox);
			set => SetProperty(ref _nameBox, value);
		}

		[Ordinal(4)] 
		[RED("StringBox")] 
		public CString StringBox
		{
			get => GetProperty(ref _stringBox);
			set => SetProperty(ref _stringBox, value);
		}

		[Ordinal(5)] 
		[RED("CNameBox")] 
		public CName CNameBox
		{
			get => GetProperty(ref _cNameBox);
			set => SetProperty(ref _cNameBox, value);
		}

		[Ordinal(6)] 
		[RED("TweakBox")] 
		public TweakDBID TweakBox
		{
			get => GetProperty(ref _tweakBox);
			set => SetProperty(ref _tweakBox, value);
		}

		public FUNC_TEST_Container_2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
