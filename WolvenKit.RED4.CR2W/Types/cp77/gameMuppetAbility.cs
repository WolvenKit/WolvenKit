using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetAbility : CVariable
	{
		private CInt32 _value;
		private CInt32 _blocks;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("blocks")] 
		public CInt32 Blocks
		{
			get => GetProperty(ref _blocks);
			set => SetProperty(ref _blocks, value);
		}

		public gameMuppetAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
