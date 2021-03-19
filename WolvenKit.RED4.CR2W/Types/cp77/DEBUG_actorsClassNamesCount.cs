using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_actorsClassNamesCount : IScriptable
	{
		private CName _className;
		private CInt32 _count;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		public DEBUG_actorsClassNamesCount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
