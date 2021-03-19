using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassemblableComponent : gameScriptableComponent
	{
		private CBool _disassembled;
		private CArray<wCHandle<gameObject>> _disassembleTargetRequesters;

		[Ordinal(5)] 
		[RED("disassembled")] 
		public CBool Disassembled
		{
			get => GetProperty(ref _disassembled);
			set => SetProperty(ref _disassembled, value);
		}

		[Ordinal(6)] 
		[RED("disassembleTargetRequesters")] 
		public CArray<wCHandle<gameObject>> DisassembleTargetRequesters
		{
			get => GetProperty(ref _disassembleTargetRequesters);
			set => SetProperty(ref _disassembleTargetRequesters, value);
		}

		public DisassemblableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
