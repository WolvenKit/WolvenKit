using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentBoolean : CheckArguments
	{
		private CBool _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CBool CustomVar
		{
			get => GetProperty(ref _customVar);
			set => SetProperty(ref _customVar, value);
		}

		public CheckArgumentBoolean(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
