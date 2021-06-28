using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_2_1_BaseClass : IScriptable
	{
		private CInt32 _prop1;
		private CInt32 _prop2;
		private CInt32 _prop3;

		[Ordinal(0)] 
		[RED("prop1")] 
		public CInt32 Prop1
		{
			get => GetProperty(ref _prop1);
			set => SetProperty(ref _prop1, value);
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get => GetProperty(ref _prop2);
			set => SetProperty(ref _prop2, value);
		}

		[Ordinal(2)] 
		[RED("prop3")] 
		public CInt32 Prop3
		{
			get => GetProperty(ref _prop3);
			set => SetProperty(ref _prop3, value);
		}

		public Ref_2_1_BaseClass(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
