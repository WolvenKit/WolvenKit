using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompareArguments : AIbehaviorconditionScript
	{
		private CName _var1;
		private CName _var2;

		[Ordinal(0)] 
		[RED("var1")] 
		public CName Var1
		{
			get => GetProperty(ref _var1);
			set => SetProperty(ref _var1, value);
		}

		[Ordinal(1)] 
		[RED("var2")] 
		public CName Var2
		{
			get => GetProperty(ref _var2);
			set => SetProperty(ref _var2, value);
		}

		public CompareArguments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
