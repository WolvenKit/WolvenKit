using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		private CBool _bool2;

		[Ordinal(1)] 
		[RED("bool2")] 
		public CBool Bool2
		{
			get => GetProperty(ref _bool2);
			set => SetProperty(ref _bool2, value);
		}

		public Sample_Customized_Replicated_Root_Object(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
