using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassembleOptions : CVariable
	{
		private CBool _canBeDisassembled;

		[Ordinal(0)] 
		[RED("canBeDisassembled")] 
		public CBool CanBeDisassembled
		{
			get => GetProperty(ref _canBeDisassembled);
			set => SetProperty(ref _canBeDisassembled, value);
		}

		public DisassembleOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
